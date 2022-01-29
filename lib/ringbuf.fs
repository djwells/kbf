: ring: ( capbits -- addr )
    \ 1<=capbits<=32
    \ Catacity will be capbits^2-1
    \ Data layout:  [ maxidx, next-out, next-in, full, cap cells... ]

    create
        1 swap lshift 1- dup dup    \ ( cap cap cap )
        , 0 , 0 ,                \ ( cap cap )  Data Header:  maxidx, tail, head
        here swap cells allot       \ ( cap item0 )
        swap cells $0 fill
    does>                           \ ( -- addr )
;

: cap ( addr -- u )
    @
;

: dataloc ( addr idx -- addr' )
    3 + cells +
;

: marker@ ( addr offset -- u )
    cells + @
;

: marker++ ( addr offset -- )
    swap dup @ swap     \ ( offset maxidx addr )
    rot cells + dup     \ ( maxidx addr-t addr-t )
    @ 1+ rot and        \ ( addr-t tail-next )
    swap !
;

: tail@ ( addr -- u )
    1 marker@
;

: tail++ ( addr -- )
    1 marker++
;

: head@ ( addr -- u )
    2 marker@
;

: head++ ( addr -- )
    2 marker++
;

: ring# ( addr -- u )
    dup dup tail@ swap head@    \ ( addr t h )
    - dup 0< if                 \ ( addr s )
        swap cap + 1+           \ ( s+ )
    else
        nip                     \ ( s )
    then
;

: full? ( addr -- )
    dup cap swap ring# =
;

: empty? ( addr -- )
    ring# 0=
;

: >ring ( u addr -- )
    tuck full? if over head++ then   \ ( addr u ) Drop the oldest item if the buffer is full
    over dup tail@ dataloc !    \ ( addr ) Store incoming data
    tail++
;

: ring> ( addr -- u flag )
    dup empty? if drop 0 false exit then    \ ( 0 0 ) No items - return empty 
    dup dup head@ dataloc @                     \ ( addr u )
    swap head++ true
;

: ring. ( addr -- )
    cr ."   Cap: " dup cap u.
    cr ."  ring#: " dup ring# u.
    cr ." Full?: " dup full? if ." True" else ." False" then
    cr ."  Tail: " dup tail@ u.
    cr ."  Head: " head@ u.
;

: ring* ( addr -- )
    cr ." -----------------------"
    cr ." COUNT: " dup ring# . space space ." CAP: " dup cap .
    cr ." -----------------------"
    dup cap 0 do
        dup i dataloc @ cr space i u.2 space space hex.
        dup tail@ i = if space ." (TAIL)" then
        dup head@ i = if space ." (HEAD)" then
    loop
    cr ." -----------------------"
;