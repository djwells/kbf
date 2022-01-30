: pin.mode.input ( u addr -- ) %00 rot 2 * lshift swap bis! ; 
: pin.mode.output ( u addr -- ) %01 rot 2 * lshift swap bis! ;
: pin.ospeed.low ( u addr -- ) $8 + %00 rot 2 * lshift swap bis! ;
: pin.ospeed.med ( u addr -- ) $8 + %01 rot 2 * lshift swap bis! ;
: pin.ospeed.high ( u addr -- ) $8 + %11 rot 2 * lshift swap bis! ;
: pin.pupd.pullup ( u addr--) $C + %01 rot 2 * lshift swap bis! ;
: pin.pupd.pulldown ( u addr--) $C + %10 rot 2 * lshift swap bis! ;

: pin.set ( u addr -- ) $18 + swap bit swap ! ;
: pin.clear ( u addr -- ) $28 + swap bit swap ! ;
: pin.read ( u addr -- ) $10 + swap bit swap bit@ ;

: WRITEONLY ( -- ) ." write-only" cr ;

$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( read-write )  \ GPIO port mode register
GPIOA $4 + constant GPIOA_OTYPER ( read-write )  \ GPIO port output type register
GPIOA $8 + constant GPIOA_OSPEEDR ( read-write )  \ GPIO port output speed  register
GPIOA $C + constant GPIOA_PUPDR ( read-write )  \ GPIO port pull-up/pull-down  register
GPIOA $10 + constant GPIOA_IDR ( read-only )  \ GPIO port input data register
GPIOA $14 + constant GPIOA_ODR ( read-write )  \ GPIO port output data register
GPIOA $18 + constant GPIOA_BSRR ( write-only )  \ GPIO port bit set/reset  register
GPIOA $1C + constant GPIOA_LCKR ( read-write )  \ GPIO port configuration lock  register
GPIOA $20 + constant GPIOA_AFRL ( read-write )  \ GPIO alternate function low  register
GPIOA $24 + constant GPIOA_AFRH ( read-write )  \ GPIO alternate function high  register
GPIOA $28 + constant GPIOA_BRR ( write-only )  \ Port bit reset register
: GPIOA_MODER. cr ." GPIOA_MODER.  RW   $" GPIOA_MODER @ dup hex.  bin1. ;
: GPIOA_OTYPER. cr ." GPIOA_OTYPER.  RW   $" GPIOA_OTYPER @ dup hex.  bin1. ;
: GPIOA_OSPEEDR. cr ." GPIOA_OSPEEDR.  RW   $" GPIOA_OSPEEDR @ dup hex.  bin1. ;
: GPIOA_PUPDR. cr ." GPIOA_PUPDR.  RW   $" GPIOA_PUPDR @ dup hex.  bin1. ;
: GPIOA_IDR. cr ." GPIOA_IDR.  RO   $" GPIOA_IDR @ dup hex.  bin1. ;
: GPIOA_ODR. cr ." GPIOA_ODR.  RW   $" GPIOA_ODR @ dup hex.  bin1. ;
: GPIOA_BSRR. cr ." GPIOA_BSRR " WRITEONLY ; 
: GPIOA_LCKR. cr ." GPIOA_LCKR.  RW   $" GPIOA_LCKR @ dup hex.  bin1. ;
: GPIOA_AFRL. cr ." GPIOA_AFRL.  RW   $" GPIOA_AFRL @ dup hex.  bin1. ;
: GPIOA_AFRH. cr ." GPIOA_AFRH.  RW   $" GPIOA_AFRH @ dup hex.  bin1. ;
: GPIOA_BRR. cr ." GPIOA_BRR " WRITEONLY ; 
: GPIOA.
GPIOA_MODER.
GPIOA_OTYPER.
GPIOA_OSPEEDR.
GPIOA_PUPDR.
GPIOA_IDR.
GPIOA_ODR.
GPIOA_BSRR.
GPIOA_LCKR.
GPIOA_AFRL.
GPIOA_AFRH.
GPIOA_BRR.
;