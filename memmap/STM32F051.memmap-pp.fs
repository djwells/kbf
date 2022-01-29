\ TEMPLATE FILE for STM32F0xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\ Available forth template words as selected by config.xm 

compiletoflash
: WRITEONLY ( -- ) ." write-only" cr ;

$40023000 constant CRC ( cyclic redundancy check calculation  unit ) 
CRC $0 + constant CRC_DR ( read-write )  \ Data register
CRC $4 + constant CRC_IDR ( read-write )  \ Independent data register
CRC $8 + constant CRC_CR ( read-write )  \ Control register
CRC $C + constant CRC_INIT ( read-write )  \ Initial CRC value
: CRC_DR. cr ." CRC_DR.  RW   $" CRC_DR @ dup hex.  bin1. ;
: CRC_IDR. cr ." CRC_IDR.  RW   $" CRC_IDR @ dup hex.  bin1. ;
: CRC_CR. cr ." CRC_CR.  RW   $" CRC_CR @ dup hex.  bin1. ;
: CRC_INIT. cr ." CRC_INIT.  RW   $" CRC_INIT @ dup hex.  bin1. ;
: CRC.
CRC_DR.
CRC_IDR.
CRC_CR.
CRC_INIT.
;

$48001400 constant GPIOF ( General-purpose I/Os ) 
GPIOF $0 + constant GPIOF_MODER ( read-write )  \ GPIO port mode register
GPIOF $4 + constant GPIOF_OTYPER ( read-write )  \ GPIO port output type register
GPIOF $8 + constant GPIOF_OSPEEDR ( read-write )  \ GPIO port output speed  register
GPIOF $C + constant GPIOF_PUPDR ( read-write )  \ GPIO port pull-up/pull-down  register
GPIOF $10 + constant GPIOF_IDR ( read-only )  \ GPIO port input data register
GPIOF $14 + constant GPIOF_ODR ( read-write )  \ GPIO port output data register
GPIOF $18 + constant GPIOF_BSRR ( write-only )  \ GPIO port bit set/reset  register
GPIOF $1C + constant GPIOF_LCKR ( read-write )  \ GPIO port configuration lock  register
GPIOF $20 + constant GPIOF_AFRL ( read-write )  \ GPIO alternate function low  register
GPIOF $24 + constant GPIOF_AFRH ( read-write )  \ GPIO alternate function high  register
GPIOF $28 + constant GPIOF_BRR ( write-only )  \ Port bit reset register
: GPIOF_MODER. cr ." GPIOF_MODER.  RW   $" GPIOF_MODER @ dup hex.  bin1. ;
: GPIOF_OTYPER. cr ." GPIOF_OTYPER.  RW   $" GPIOF_OTYPER @ dup hex.  bin1. ;
: GPIOF_OSPEEDR. cr ." GPIOF_OSPEEDR.  RW   $" GPIOF_OSPEEDR @ dup hex.  bin1. ;
: GPIOF_PUPDR. cr ." GPIOF_PUPDR.  RW   $" GPIOF_PUPDR @ dup hex.  bin1. ;
: GPIOF_IDR. cr ." GPIOF_IDR.  RO   $" GPIOF_IDR @ dup hex.  bin1. ;
: GPIOF_ODR. cr ." GPIOF_ODR.  RW   $" GPIOF_ODR @ dup hex.  bin1. ;
: GPIOF_BSRR. cr ." GPIOF_BSRR " WRITEONLY ; 
: GPIOF_LCKR. cr ." GPIOF_LCKR.  RW   $" GPIOF_LCKR @ dup hex.  bin1. ;
: GPIOF_AFRL. cr ." GPIOF_AFRL.  RW   $" GPIOF_AFRL @ dup hex.  bin1. ;
: GPIOF_AFRH. cr ." GPIOF_AFRH.  RW   $" GPIOF_AFRH @ dup hex.  bin1. ;
: GPIOF_BRR. cr ." GPIOF_BRR " WRITEONLY ; 
: GPIOF.
GPIOF_MODER.
GPIOF_OTYPER.
GPIOF_OSPEEDR.
GPIOF_PUPDR.
GPIOF_IDR.
GPIOF_ODR.
GPIOF_BSRR.
GPIOF_LCKR.
GPIOF_AFRL.
GPIOF_AFRH.
GPIOF_BRR.
;

$48000C00 constant GPIOD ( General-purpose I/Os ) 
GPIOD $0 + constant GPIOD_MODER ( read-write )  \ GPIO port mode register
GPIOD $4 + constant GPIOD_OTYPER ( read-write )  \ GPIO port output type register
GPIOD $8 + constant GPIOD_OSPEEDR ( read-write )  \ GPIO port output speed  register
GPIOD $C + constant GPIOD_PUPDR ( read-write )  \ GPIO port pull-up/pull-down  register
GPIOD $10 + constant GPIOD_IDR ( read-only )  \ GPIO port input data register
GPIOD $14 + constant GPIOD_ODR ( read-write )  \ GPIO port output data register
GPIOD $18 + constant GPIOD_BSRR ( write-only )  \ GPIO port bit set/reset  register
GPIOD $1C + constant GPIOD_LCKR ( read-write )  \ GPIO port configuration lock  register
GPIOD $20 + constant GPIOD_AFRL ( read-write )  \ GPIO alternate function low  register
GPIOD $24 + constant GPIOD_AFRH ( read-write )  \ GPIO alternate function high  register
GPIOD $28 + constant GPIOD_BRR ( write-only )  \ Port bit reset register
: GPIOD_MODER. cr ." GPIOD_MODER.  RW   $" GPIOD_MODER @ dup hex.  bin1. ;
: GPIOD_OTYPER. cr ." GPIOD_OTYPER.  RW   $" GPIOD_OTYPER @ dup hex.  bin1. ;
: GPIOD_OSPEEDR. cr ." GPIOD_OSPEEDR.  RW   $" GPIOD_OSPEEDR @ dup hex.  bin1. ;
: GPIOD_PUPDR. cr ." GPIOD_PUPDR.  RW   $" GPIOD_PUPDR @ dup hex.  bin1. ;
: GPIOD_IDR. cr ." GPIOD_IDR.  RO   $" GPIOD_IDR @ dup hex.  bin1. ;
: GPIOD_ODR. cr ." GPIOD_ODR.  RW   $" GPIOD_ODR @ dup hex.  bin1. ;
: GPIOD_BSRR. cr ." GPIOD_BSRR " WRITEONLY ; 
: GPIOD_LCKR. cr ." GPIOD_LCKR.  RW   $" GPIOD_LCKR @ dup hex.  bin1. ;
: GPIOD_AFRL. cr ." GPIOD_AFRL.  RW   $" GPIOD_AFRL @ dup hex.  bin1. ;
: GPIOD_AFRH. cr ." GPIOD_AFRH.  RW   $" GPIOD_AFRH @ dup hex.  bin1. ;
: GPIOD_BRR. cr ." GPIOD_BRR " WRITEONLY ; 
: GPIOD.
GPIOD_MODER.
GPIOD_OTYPER.
GPIOD_OSPEEDR.
GPIOD_PUPDR.
GPIOD_IDR.
GPIOD_ODR.
GPIOD_BSRR.
GPIOD_LCKR.
GPIOD_AFRL.
GPIOD_AFRH.
GPIOD_BRR.
;

$48000800 constant GPIOC ( General-purpose I/Os ) 
GPIOC $0 + constant GPIOC_MODER ( read-write )  \ GPIO port mode register
GPIOC $4 + constant GPIOC_OTYPER ( read-write )  \ GPIO port output type register
GPIOC $8 + constant GPIOC_OSPEEDR ( read-write )  \ GPIO port output speed  register
GPIOC $C + constant GPIOC_PUPDR ( read-write )  \ GPIO port pull-up/pull-down  register
GPIOC $10 + constant GPIOC_IDR ( read-only )  \ GPIO port input data register
GPIOC $14 + constant GPIOC_ODR ( read-write )  \ GPIO port output data register
GPIOC $18 + constant GPIOC_BSRR ( write-only )  \ GPIO port bit set/reset  register
GPIOC $1C + constant GPIOC_LCKR ( read-write )  \ GPIO port configuration lock  register
GPIOC $20 + constant GPIOC_AFRL ( read-write )  \ GPIO alternate function low  register
GPIOC $24 + constant GPIOC_AFRH ( read-write )  \ GPIO alternate function high  register
GPIOC $28 + constant GPIOC_BRR ( write-only )  \ Port bit reset register
: GPIOC_MODER. cr ." GPIOC_MODER.  RW   $" GPIOC_MODER @ dup hex.  bin1. ;
: GPIOC_OTYPER. cr ." GPIOC_OTYPER.  RW   $" GPIOC_OTYPER @ dup hex.  bin1. ;
: GPIOC_OSPEEDR. cr ." GPIOC_OSPEEDR.  RW   $" GPIOC_OSPEEDR @ dup hex.  bin1. ;
: GPIOC_PUPDR. cr ." GPIOC_PUPDR.  RW   $" GPIOC_PUPDR @ dup hex.  bin1. ;
: GPIOC_IDR. cr ." GPIOC_IDR.  RO   $" GPIOC_IDR @ dup hex.  bin1. ;
: GPIOC_ODR. cr ." GPIOC_ODR.  RW   $" GPIOC_ODR @ dup hex.  bin1. ;
: GPIOC_BSRR. cr ." GPIOC_BSRR " WRITEONLY ; 
: GPIOC_LCKR. cr ." GPIOC_LCKR.  RW   $" GPIOC_LCKR @ dup hex.  bin1. ;
: GPIOC_AFRL. cr ." GPIOC_AFRL.  RW   $" GPIOC_AFRL @ dup hex.  bin1. ;
: GPIOC_AFRH. cr ." GPIOC_AFRH.  RW   $" GPIOC_AFRH @ dup hex.  bin1. ;
: GPIOC_BRR. cr ." GPIOC_BRR " WRITEONLY ; 
: GPIOC.
GPIOC_MODER.
GPIOC_OTYPER.
GPIOC_OSPEEDR.
GPIOC_PUPDR.
GPIOC_IDR.
GPIOC_ODR.
GPIOC_BSRR.
GPIOC_LCKR.
GPIOC_AFRL.
GPIOC_AFRH.
GPIOC_BRR.
;

$48000400 constant GPIOB ( General-purpose I/Os ) 
GPIOB $0 + constant GPIOB_MODER ( read-write )  \ GPIO port mode register
GPIOB $4 + constant GPIOB_OTYPER ( read-write )  \ GPIO port output type register
GPIOB $8 + constant GPIOB_OSPEEDR ( read-write )  \ GPIO port output speed  register
GPIOB $C + constant GPIOB_PUPDR ( read-write )  \ GPIO port pull-up/pull-down  register
GPIOB $10 + constant GPIOB_IDR ( read-only )  \ GPIO port input data register
GPIOB $14 + constant GPIOB_ODR ( read-write )  \ GPIO port output data register
GPIOB $18 + constant GPIOB_BSRR ( write-only )  \ GPIO port bit set/reset  register
GPIOB $1C + constant GPIOB_LCKR ( read-write )  \ GPIO port configuration lock  register
GPIOB $20 + constant GPIOB_AFRL ( read-write )  \ GPIO alternate function low  register
GPIOB $24 + constant GPIOB_AFRH ( read-write )  \ GPIO alternate function high  register
GPIOB $28 + constant GPIOB_BRR ( write-only )  \ Port bit reset register
: GPIOB_MODER. cr ." GPIOB_MODER.  RW   $" GPIOB_MODER @ dup hex.  bin1. ;
: GPIOB_OTYPER. cr ." GPIOB_OTYPER.  RW   $" GPIOB_OTYPER @ dup hex.  bin1. ;
: GPIOB_OSPEEDR. cr ." GPIOB_OSPEEDR.  RW   $" GPIOB_OSPEEDR @ dup hex.  bin1. ;
: GPIOB_PUPDR. cr ." GPIOB_PUPDR.  RW   $" GPIOB_PUPDR @ dup hex.  bin1. ;
: GPIOB_IDR. cr ." GPIOB_IDR.  RO   $" GPIOB_IDR @ dup hex.  bin1. ;
: GPIOB_ODR. cr ." GPIOB_ODR.  RW   $" GPIOB_ODR @ dup hex.  bin1. ;
: GPIOB_BSRR. cr ." GPIOB_BSRR " WRITEONLY ; 
: GPIOB_LCKR. cr ." GPIOB_LCKR.  RW   $" GPIOB_LCKR @ dup hex.  bin1. ;
: GPIOB_AFRL. cr ." GPIOB_AFRL.  RW   $" GPIOB_AFRL @ dup hex.  bin1. ;
: GPIOB_AFRH. cr ." GPIOB_AFRH.  RW   $" GPIOB_AFRH @ dup hex.  bin1. ;
: GPIOB_BRR. cr ." GPIOB_BRR " WRITEONLY ; 
: GPIOB.
GPIOB_MODER.
GPIOB_OTYPER.
GPIOB_OSPEEDR.
GPIOB_PUPDR.
GPIOB_IDR.
GPIOB_ODR.
GPIOB_BSRR.
GPIOB_LCKR.
GPIOB_AFRL.
GPIOB_AFRH.
GPIOB_BRR.
;

$48001000 constant GPIOE ( General-purpose I/Os ) 
GPIOE $0 + constant GPIOE_MODER ( read-write )  \ GPIO port mode register
GPIOE $4 + constant GPIOE_OTYPER ( read-write )  \ GPIO port output type register
GPIOE $8 + constant GPIOE_OSPEEDR ( read-write )  \ GPIO port output speed  register
GPIOE $C + constant GPIOE_PUPDR ( read-write )  \ GPIO port pull-up/pull-down  register
GPIOE $10 + constant GPIOE_IDR ( read-only )  \ GPIO port input data register
GPIOE $14 + constant GPIOE_ODR ( read-write )  \ GPIO port output data register
GPIOE $18 + constant GPIOE_BSRR ( write-only )  \ GPIO port bit set/reset  register
GPIOE $1C + constant GPIOE_LCKR ( read-write )  \ GPIO port configuration lock  register
GPIOE $20 + constant GPIOE_AFRL ( read-write )  \ GPIO alternate function low  register
GPIOE $24 + constant GPIOE_AFRH ( read-write )  \ GPIO alternate function high  register
GPIOE $28 + constant GPIOE_BRR ( write-only )  \ Port bit reset register
: GPIOE_MODER. cr ." GPIOE_MODER.  RW   $" GPIOE_MODER @ dup hex.  bin1. ;
: GPIOE_OTYPER. cr ." GPIOE_OTYPER.  RW   $" GPIOE_OTYPER @ dup hex.  bin1. ;
: GPIOE_OSPEEDR. cr ." GPIOE_OSPEEDR.  RW   $" GPIOE_OSPEEDR @ dup hex.  bin1. ;
: GPIOE_PUPDR. cr ." GPIOE_PUPDR.  RW   $" GPIOE_PUPDR @ dup hex.  bin1. ;
: GPIOE_IDR. cr ." GPIOE_IDR.  RO   $" GPIOE_IDR @ dup hex.  bin1. ;
: GPIOE_ODR. cr ." GPIOE_ODR.  RW   $" GPIOE_ODR @ dup hex.  bin1. ;
: GPIOE_BSRR. cr ." GPIOE_BSRR " WRITEONLY ; 
: GPIOE_LCKR. cr ." GPIOE_LCKR.  RW   $" GPIOE_LCKR @ dup hex.  bin1. ;
: GPIOE_AFRL. cr ." GPIOE_AFRL.  RW   $" GPIOE_AFRL @ dup hex.  bin1. ;
: GPIOE_AFRH. cr ." GPIOE_AFRH.  RW   $" GPIOE_AFRH @ dup hex.  bin1. ;
: GPIOE_BRR. cr ." GPIOE_BRR " WRITEONLY ; 
: GPIOE.
GPIOE_MODER.
GPIOE_OTYPER.
GPIOE_OSPEEDR.
GPIOE_PUPDR.
GPIOE_IDR.
GPIOE_ODR.
GPIOE_BSRR.
GPIOE_LCKR.
GPIOE_AFRL.
GPIOE_AFRH.
GPIOE_BRR.
;

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

$40012C00 constant TIM1 ( Advanced-timers ) 
TIM1 $0 + constant TIM1_CR1 ( read-write )  \ control register 1
TIM1 $4 + constant TIM1_CR2 ( read-write )  \ control register 2
TIM1 $8 + constant TIM1_SMCR ( read-write )  \ slave mode control register
TIM1 $C + constant TIM1_DIER ( read-write )  \ DMA/Interrupt enable register
TIM1 $10 + constant TIM1_SR ( read-write )  \ status register
TIM1 $14 + constant TIM1_EGR ( write-only )  \ event generation register
TIM1 $18 + constant TIM1_CCMR1_Output ( read-write )  \ capture/compare mode register output  mode
TIM1 $18 + constant TIM1_CCMR1_Input ( read-write )  \ capture/compare mode register 1 input  mode
TIM1 $1C + constant TIM1_CCMR2_Output ( read-write )  \ capture/compare mode register output  mode
TIM1 $1C + constant TIM1_CCMR2_Input ( read-write )  \ capture/compare mode register 2 input  mode
TIM1 $20 + constant TIM1_CCER ( read-write )  \ capture/compare enable  register
TIM1 $24 + constant TIM1_CNT ( read-write )  \ counter
TIM1 $28 + constant TIM1_PSC ( read-write )  \ prescaler
TIM1 $2C + constant TIM1_ARR ( read-write )  \ auto-reload register
TIM1 $30 + constant TIM1_RCR ( read-write )  \ repetition counter register
TIM1 $34 + constant TIM1_CCR1 ( read-write )  \ capture/compare register 1
TIM1 $38 + constant TIM1_CCR2 ( read-write )  \ capture/compare register 2
TIM1 $3C + constant TIM1_CCR3 ( read-write )  \ capture/compare register 3
TIM1 $40 + constant TIM1_CCR4 ( read-write )  \ capture/compare register 4
TIM1 $44 + constant TIM1_BDTR ( read-write )  \ break and dead-time register
TIM1 $48 + constant TIM1_DCR ( read-write )  \ DMA control register
TIM1 $4C + constant TIM1_DMAR ( read-write )  \ DMA address for full transfer
: TIM1_CR1. cr ." TIM1_CR1.  RW   $" TIM1_CR1 @ dup hex.  bin1. ;
: TIM1_CR2. cr ." TIM1_CR2.  RW   $" TIM1_CR2 @ dup hex.  bin1. ;
: TIM1_SMCR. cr ." TIM1_SMCR.  RW   $" TIM1_SMCR @ dup hex.  bin1. ;
: TIM1_DIER. cr ." TIM1_DIER.  RW   $" TIM1_DIER @ dup hex.  bin1. ;
: TIM1_SR. cr ." TIM1_SR.  RW   $" TIM1_SR @ dup hex.  bin1. ;
: TIM1_EGR. cr ." TIM1_EGR " WRITEONLY ; 
: TIM1_CCMR1_Output. cr ." TIM1_CCMR1_Output.  RW   $" TIM1_CCMR1_Output @ dup hex.  bin1. ;
: TIM1_CCMR1_Input. cr ." TIM1_CCMR1_Input.  RW   $" TIM1_CCMR1_Input @ dup hex.  bin1. ;
: TIM1_CCMR2_Output. cr ." TIM1_CCMR2_Output.  RW   $" TIM1_CCMR2_Output @ dup hex.  bin1. ;
: TIM1_CCMR2_Input. cr ." TIM1_CCMR2_Input.  RW   $" TIM1_CCMR2_Input @ dup hex.  bin1. ;
: TIM1_CCER. cr ." TIM1_CCER.  RW   $" TIM1_CCER @ dup hex.  bin1. ;
: TIM1_CNT. cr ." TIM1_CNT.  RW   $" TIM1_CNT @ dup hex.  bin1. ;
: TIM1_PSC. cr ." TIM1_PSC.  RW   $" TIM1_PSC @ dup hex.  bin1. ;
: TIM1_ARR. cr ." TIM1_ARR.  RW   $" TIM1_ARR @ dup hex.  bin1. ;
: TIM1_RCR. cr ." TIM1_RCR.  RW   $" TIM1_RCR @ dup hex.  bin1. ;
: TIM1_CCR1. cr ." TIM1_CCR1.  RW   $" TIM1_CCR1 @ dup hex.  bin1. ;
: TIM1_CCR2. cr ." TIM1_CCR2.  RW   $" TIM1_CCR2 @ dup hex.  bin1. ;
: TIM1_CCR3. cr ." TIM1_CCR3.  RW   $" TIM1_CCR3 @ dup hex.  bin1. ;
: TIM1_CCR4. cr ." TIM1_CCR4.  RW   $" TIM1_CCR4 @ dup hex.  bin1. ;
: TIM1_BDTR. cr ." TIM1_BDTR.  RW   $" TIM1_BDTR @ dup hex.  bin1. ;
: TIM1_DCR. cr ." TIM1_DCR.  RW   $" TIM1_DCR @ dup hex.  bin1. ;
: TIM1_DMAR. cr ." TIM1_DMAR.  RW   $" TIM1_DMAR @ dup hex.  bin1. ;
: TIM1.
TIM1_CR1.
TIM1_CR2.
TIM1_SMCR.
TIM1_DIER.
TIM1_SR.
TIM1_EGR.
TIM1_CCMR1_Output.
TIM1_CCMR1_Input.
TIM1_CCMR2_Output.
TIM1_CCMR2_Input.
TIM1_CCER.
TIM1_CNT.
TIM1_PSC.
TIM1_ARR.
TIM1_RCR.
TIM1_CCR1.
TIM1_CCR2.
TIM1_CCR3.
TIM1_CCR4.
TIM1_BDTR.
TIM1_DCR.
TIM1_DMAR.
;

$40000000 constant TIM2 ( General-purpose-timers ) 
TIM2 $0 + constant TIM2_CR1 ( read-write )  \ control register 1
TIM2 $4 + constant TIM2_CR2 ( read-write )  \ control register 2
TIM2 $8 + constant TIM2_SMCR ( read-write )  \ slave mode control register
TIM2 $C + constant TIM2_DIER ( read-write )  \ DMA/Interrupt enable register
TIM2 $10 + constant TIM2_SR ( read-write )  \ status register
TIM2 $14 + constant TIM2_EGR ( write-only )  \ event generation register
TIM2 $18 + constant TIM2_CCMR1_Output ( read-write )  \ capture/compare mode register 1 output  mode
TIM2 $18 + constant TIM2_CCMR1_Input ( read-write )  \ capture/compare mode register 1 input  mode
TIM2 $1C + constant TIM2_CCMR2_Output ( read-write )  \ capture/compare mode register 2 output  mode
TIM2 $1C + constant TIM2_CCMR2_Input ( read-write )  \ capture/compare mode register 2 input  mode
TIM2 $20 + constant TIM2_CCER ( read-write )  \ capture/compare enable  register
TIM2 $24 + constant TIM2_CNT ( read-write )  \ counter
TIM2 $28 + constant TIM2_PSC ( read-write )  \ prescaler
TIM2 $2C + constant TIM2_ARR ( read-write )  \ auto-reload register
TIM2 $34 + constant TIM2_CCR1 ( read-write )  \ capture/compare register 1
TIM2 $38 + constant TIM2_CCR2 ( read-write )  \ capture/compare register 2
TIM2 $3C + constant TIM2_CCR3 ( read-write )  \ capture/compare register 3
TIM2 $40 + constant TIM2_CCR4 ( read-write )  \ capture/compare register 4
TIM2 $48 + constant TIM2_DCR ( read-write )  \ DMA control register
TIM2 $4C + constant TIM2_DMAR ( read-write )  \ DMA address for full transfer
: TIM2_CR1. cr ." TIM2_CR1.  RW   $" TIM2_CR1 @ dup hex.  bin1. ;
: TIM2_CR2. cr ." TIM2_CR2.  RW   $" TIM2_CR2 @ dup hex.  bin1. ;
: TIM2_SMCR. cr ." TIM2_SMCR.  RW   $" TIM2_SMCR @ dup hex.  bin1. ;
: TIM2_DIER. cr ." TIM2_DIER.  RW   $" TIM2_DIER @ dup hex.  bin1. ;
: TIM2_SR. cr ." TIM2_SR.  RW   $" TIM2_SR @ dup hex.  bin1. ;
: TIM2_EGR. cr ." TIM2_EGR " WRITEONLY ; 
: TIM2_CCMR1_Output. cr ." TIM2_CCMR1_Output.  RW   $" TIM2_CCMR1_Output @ dup hex.  bin1. ;
: TIM2_CCMR1_Input. cr ." TIM2_CCMR1_Input.  RW   $" TIM2_CCMR1_Input @ dup hex.  bin1. ;
: TIM2_CCMR2_Output. cr ." TIM2_CCMR2_Output.  RW   $" TIM2_CCMR2_Output @ dup hex.  bin1. ;
: TIM2_CCMR2_Input. cr ." TIM2_CCMR2_Input.  RW   $" TIM2_CCMR2_Input @ dup hex.  bin1. ;
: TIM2_CCER. cr ." TIM2_CCER.  RW   $" TIM2_CCER @ dup hex.  bin1. ;
: TIM2_CNT. cr ." TIM2_CNT.  RW   $" TIM2_CNT @ dup hex.  bin1. ;
: TIM2_PSC. cr ." TIM2_PSC.  RW   $" TIM2_PSC @ dup hex.  bin1. ;
: TIM2_ARR. cr ." TIM2_ARR.  RW   $" TIM2_ARR @ dup hex.  bin1. ;
: TIM2_CCR1. cr ." TIM2_CCR1.  RW   $" TIM2_CCR1 @ dup hex.  bin1. ;
: TIM2_CCR2. cr ." TIM2_CCR2.  RW   $" TIM2_CCR2 @ dup hex.  bin1. ;
: TIM2_CCR3. cr ." TIM2_CCR3.  RW   $" TIM2_CCR3 @ dup hex.  bin1. ;
: TIM2_CCR4. cr ." TIM2_CCR4.  RW   $" TIM2_CCR4 @ dup hex.  bin1. ;
: TIM2_DCR. cr ." TIM2_DCR.  RW   $" TIM2_DCR @ dup hex.  bin1. ;
: TIM2_DMAR. cr ." TIM2_DMAR.  RW   $" TIM2_DMAR @ dup hex.  bin1. ;
: TIM2.
TIM2_CR1.
TIM2_CR2.
TIM2_SMCR.
TIM2_DIER.
TIM2_SR.
TIM2_EGR.
TIM2_CCMR1_Output.
TIM2_CCMR1_Input.
TIM2_CCMR2_Output.
TIM2_CCMR2_Input.
TIM2_CCER.
TIM2_CNT.
TIM2_PSC.
TIM2_ARR.
TIM2_CCR1.
TIM2_CCR2.
TIM2_CCR3.
TIM2_CCR4.
TIM2_DCR.
TIM2_DMAR.
;

$40000400 constant TIM3 ( General-purpose-timers ) 
TIM3 $0 + constant TIM3_CR1 ( read-write )  \ control register 1
TIM3 $4 + constant TIM3_CR2 ( read-write )  \ control register 2
TIM3 $8 + constant TIM3_SMCR ( read-write )  \ slave mode control register
TIM3 $C + constant TIM3_DIER ( read-write )  \ DMA/Interrupt enable register
TIM3 $10 + constant TIM3_SR ( read-write )  \ status register
TIM3 $14 + constant TIM3_EGR ( write-only )  \ event generation register
TIM3 $18 + constant TIM3_CCMR1_Output ( read-write )  \ capture/compare mode register 1 output  mode
TIM3 $18 + constant TIM3_CCMR1_Input ( read-write )  \ capture/compare mode register 1 input  mode
TIM3 $1C + constant TIM3_CCMR2_Output ( read-write )  \ capture/compare mode register 2 output  mode
TIM3 $1C + constant TIM3_CCMR2_Input ( read-write )  \ capture/compare mode register 2 input  mode
TIM3 $20 + constant TIM3_CCER ( read-write )  \ capture/compare enable  register
TIM3 $24 + constant TIM3_CNT ( read-write )  \ counter
TIM3 $28 + constant TIM3_PSC ( read-write )  \ prescaler
TIM3 $2C + constant TIM3_ARR ( read-write )  \ auto-reload register
TIM3 $34 + constant TIM3_CCR1 ( read-write )  \ capture/compare register 1
TIM3 $38 + constant TIM3_CCR2 ( read-write )  \ capture/compare register 2
TIM3 $3C + constant TIM3_CCR3 ( read-write )  \ capture/compare register 3
TIM3 $40 + constant TIM3_CCR4 ( read-write )  \ capture/compare register 4
TIM3 $48 + constant TIM3_DCR ( read-write )  \ DMA control register
TIM3 $4C + constant TIM3_DMAR ( read-write )  \ DMA address for full transfer
: TIM3_CR1. cr ." TIM3_CR1.  RW   $" TIM3_CR1 @ dup hex.  bin1. ;
: TIM3_CR2. cr ." TIM3_CR2.  RW   $" TIM3_CR2 @ dup hex.  bin1. ;
: TIM3_SMCR. cr ." TIM3_SMCR.  RW   $" TIM3_SMCR @ dup hex.  bin1. ;
: TIM3_DIER. cr ." TIM3_DIER.  RW   $" TIM3_DIER @ dup hex.  bin1. ;
: TIM3_SR. cr ." TIM3_SR.  RW   $" TIM3_SR @ dup hex.  bin1. ;
: TIM3_EGR. cr ." TIM3_EGR " WRITEONLY ; 
: TIM3_CCMR1_Output. cr ." TIM3_CCMR1_Output.  RW   $" TIM3_CCMR1_Output @ dup hex.  bin1. ;
: TIM3_CCMR1_Input. cr ." TIM3_CCMR1_Input.  RW   $" TIM3_CCMR1_Input @ dup hex.  bin1. ;
: TIM3_CCMR2_Output. cr ." TIM3_CCMR2_Output.  RW   $" TIM3_CCMR2_Output @ dup hex.  bin1. ;
: TIM3_CCMR2_Input. cr ." TIM3_CCMR2_Input.  RW   $" TIM3_CCMR2_Input @ dup hex.  bin1. ;
: TIM3_CCER. cr ." TIM3_CCER.  RW   $" TIM3_CCER @ dup hex.  bin1. ;
: TIM3_CNT. cr ." TIM3_CNT.  RW   $" TIM3_CNT @ dup hex.  bin1. ;
: TIM3_PSC. cr ." TIM3_PSC.  RW   $" TIM3_PSC @ dup hex.  bin1. ;
: TIM3_ARR. cr ." TIM3_ARR.  RW   $" TIM3_ARR @ dup hex.  bin1. ;
: TIM3_CCR1. cr ." TIM3_CCR1.  RW   $" TIM3_CCR1 @ dup hex.  bin1. ;
: TIM3_CCR2. cr ." TIM3_CCR2.  RW   $" TIM3_CCR2 @ dup hex.  bin1. ;
: TIM3_CCR3. cr ." TIM3_CCR3.  RW   $" TIM3_CCR3 @ dup hex.  bin1. ;
: TIM3_CCR4. cr ." TIM3_CCR4.  RW   $" TIM3_CCR4 @ dup hex.  bin1. ;
: TIM3_DCR. cr ." TIM3_DCR.  RW   $" TIM3_DCR @ dup hex.  bin1. ;
: TIM3_DMAR. cr ." TIM3_DMAR.  RW   $" TIM3_DMAR @ dup hex.  bin1. ;
: TIM3.
TIM3_CR1.
TIM3_CR2.
TIM3_SMCR.
TIM3_DIER.
TIM3_SR.
TIM3_EGR.
TIM3_CCMR1_Output.
TIM3_CCMR1_Input.
TIM3_CCMR2_Output.
TIM3_CCMR2_Input.
TIM3_CCER.
TIM3_CNT.
TIM3_PSC.
TIM3_ARR.
TIM3_CCR1.
TIM3_CCR2.
TIM3_CCR3.
TIM3_CCR4.
TIM3_DCR.
TIM3_DMAR.
;

$40001000 constant TIM6 ( Basic-timers ) 
TIM6 $0 + constant TIM6_CR1 ( read-write )  \ control register 1
TIM6 $4 + constant TIM6_CR2 ( read-write )  \ control register 2
TIM6 $C + constant TIM6_DIER ( read-write )  \ DMA/Interrupt enable register
TIM6 $10 + constant TIM6_SR ( read-write )  \ status register
TIM6 $14 + constant TIM6_EGR ( write-only )  \ event generation register
TIM6 $24 + constant TIM6_CNT ( read-write )  \ counter
TIM6 $28 + constant TIM6_PSC ( read-write )  \ prescaler
TIM6 $2C + constant TIM6_ARR ( read-write )  \ auto-reload register
: TIM6_CR1. cr ." TIM6_CR1.  RW   $" TIM6_CR1 @ dup hex.  bin1. ;
: TIM6_CR2. cr ." TIM6_CR2.  RW   $" TIM6_CR2 @ dup hex.  bin1. ;
: TIM6_DIER. cr ." TIM6_DIER.  RW   $" TIM6_DIER @ dup hex.  bin1. ;
: TIM6_SR. cr ." TIM6_SR.  RW   $" TIM6_SR @ dup hex.  bin1. ;
: TIM6_EGR. cr ." TIM6_EGR " WRITEONLY ; 
: TIM6_CNT. cr ." TIM6_CNT.  RW   $" TIM6_CNT @ dup hex.  bin1. ;
: TIM6_PSC. cr ." TIM6_PSC.  RW   $" TIM6_PSC @ dup hex.  bin1. ;
: TIM6_ARR. cr ." TIM6_ARR.  RW   $" TIM6_ARR @ dup hex.  bin1. ;
: TIM6.
TIM6_CR1.
TIM6_CR2.
TIM6_DIER.
TIM6_SR.
TIM6_EGR.
TIM6_CNT.
TIM6_PSC.
TIM6_ARR.
;

$40022000 constant Flash ( Flash ) 
Flash $0 + constant Flash_ACR (  )  \ Flash access control register
Flash $4 + constant Flash_KEYR ( write-only )  \ Flash key register
Flash $8 + constant Flash_OPTKEYR ( write-only )  \ Flash option key register
Flash $C + constant Flash_SR (  )  \ Flash status register
Flash $10 + constant Flash_CR ( read-write )  \ Flash control register
Flash $14 + constant Flash_AR ( write-only )  \ Flash address register
Flash $1C + constant Flash_OBR ( read-only )  \ Option byte register
Flash $20 + constant Flash_WRPR ( read-only )  \ Write protection register
: Flash_ACR. cr ." Flash_ACR.   $" Flash_ACR @ dup hex.  bin1. ;
: Flash_KEYR. cr ." Flash_KEYR " WRITEONLY ; 
: Flash_OPTKEYR. cr ." Flash_OPTKEYR " WRITEONLY ; 
: Flash_SR. cr ." Flash_SR.   $" Flash_SR @ dup hex.  bin1. ;
: Flash_CR. cr ." Flash_CR.  RW   $" Flash_CR @ dup hex.  bin1. ;
: Flash_AR. cr ." Flash_AR " WRITEONLY ; 
: Flash_OBR. cr ." Flash_OBR.  RO   $" Flash_OBR @ dup hex.  bin1. ;
: Flash_WRPR. cr ." Flash_WRPR.  RO   $" Flash_WRPR @ dup hex.  bin1. ;
: Flash.
Flash_ACR.
Flash_KEYR.
Flash_OPTKEYR.
Flash_SR.
Flash_CR.
Flash_AR.
Flash_OBR.
Flash_WRPR.
;


compiletoram
