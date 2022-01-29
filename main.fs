#require bitfields.fs
#require f0-millis.fs

8 constant rows
8 constant cols
rows cols * constant numkeys

: init-gpio
    cr
    cols . ." cols" cr
    rows . ." rows" cr
    numkeys . ." keys" cr
    cols 0 do
        ." Setting pin " i . ." to output mode, med speed" cr
        i gpioa pin.mode.output
        i gpioa pin.ospeed.med
    loop
    cols rows + cols do
        ." Setting pin " i . ." to input mode, med speed (?), pull down" cr
        i gpioa pin.mode.input
        i gpioa pin.pupd.pulldown
    loop
    ." gpio initialized" cr
;

numkeys cells buffer: keystate
: init-keystate
    numkeys 0 do
        %0 keystate i cells + !
    loop
    ." keystate initialized" cr
;

: init
    init-systick
    init-gpio
    init-keystate
    ." ready." cr
;

: word.
    base @ swap
    0
    binary
    <#
    32 0 do # loop
    #>
    type
    base !
;

: keystate.
    cr
    numkeys 0 do
        hex i . ." | "
        keystate i cells + @ word. cr
    loop
    decimal
;

: column_on  ( col -- )
    gpioa pin.set
;

: column_off  ( col -- )
    gpioa pin.clear
;

: readkey ( col row -- )
    dup rot rows * + cells keystate + swap ( addr row )
    cols + gpioa pin.read ( addr pinval )
    over @ shl or swap !
;

: scan_matrix ( -- )
    cols 0 do
        i column_on
        rows 0 do
            j i readkey
        loop
        i column_off
    loop
;

: readkey2 ( addr row -- )
    cols + gpioa pin.read ( addr pinval )
    over @ shl or swap !
;

: scan_matrix2 ( -- )
    keystate
    cols 0 do
        i column_on
        rows 0 do
            dup i readkey2
            cell+
        loop
        i column_off
    loop
;



: testmatrix
    millis.reset

    1000 0 do scan_matrix loop

    millis.read
    gpioa_odr.
;

: testmatrix2
    millis.reset

    32 0 do scan_matrix2 loop

    millis.read
    gpioa_odr.
;


