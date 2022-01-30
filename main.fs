3 constant rows
3 constant cols
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

0 variable keystate

: init
    init-systick
    init-gpio
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
    keystate @ word.
;

: column_on  ( col -- )
    gpioa pin.set
;

: column_off  ( col -- )
    gpioa pin.clear
;

: readrow ( row -- flag )
    cols + gpioa pin.read
;

: scan_matrix ( -- )
    %01 %00                 ( mask ks )
    cols 0 do
        i column_on
        rows 0 do           ( mask ks )
            i readrow       ( mask ks pv )
            rot tuck and    ( ks mask pv' )
            swap shl        ( ks pv' mask' )
            rot rot or      ( mask' ks' )
        loop
        i column_off
    loop
    nip keystate !
;

: testmatrix
    millis.reset
     500000 dup
     0 do
        keystate @
        scan_matrix
        keystate @
        <> if
            keystate.
        then
    loop

    cr . ." iterations = "
    millis.read
;

: scanloop
    begin
        keystate @
        scan_matrix
        keystate @
        <> if
            keystate.
        then
    key? until
;