: pin.mode.input ( u addr -- ) %00 rot 2 * lshift swap bis! ; 
: pin.mode.output ( u addr -- ) %01 rot 2 * lshift swap bis! ;
: pin.ospeed.low ( u addr -- ) $8 + %00 rot 2 * lshift swap bis! ;
: pin.ospeed.med ( u addr -- ) $8 + %01 rot 2 * lshift swap bis! ;
: pin.ospeed.high ( u addr -- ) $8 + %11 rot 2 * lshift swap bis! ;
: pin.pupd.pullup ( u addr--) $C + %01 rot 2 * lshift swap bis! ;
: pin.pupd.pulldown ( u addr--) $C + %10 rot 2 * lshift swap bis! ;

: pin.set ( u addr -- ) $18 + swap bit swap ! ;
: pin.clear ( u addr -- ) $28 + swap bit swap ! ;
: pin.read ( u addr -- ) $14 + swap bit swap bit@ ;