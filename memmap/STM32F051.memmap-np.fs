\ TEMPLATE FILE for STM32F0xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\ Available forth template words as selected by config.xm 

compiletoflash


$40023000 constant CRC ( cyclic redundancy check calculation  unit ) 
CRC $0 + constant CRC_DR ( read-write )  \ Data register
CRC $4 + constant CRC_IDR ( read-write )  \ Independent data register
CRC $8 + constant CRC_CR ( read-write )  \ Control register
CRC $C + constant CRC_INIT ( read-write )  \ Initial CRC value
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
$40001000 constant TIM6 ( Basic-timers ) 
TIM6 $0 + constant TIM6_CR1 ( read-write )  \ control register 1
TIM6 $4 + constant TIM6_CR2 ( read-write )  \ control register 2
TIM6 $C + constant TIM6_DIER ( read-write )  \ DMA/Interrupt enable register
TIM6 $10 + constant TIM6_SR ( read-write )  \ status register
TIM6 $14 + constant TIM6_EGR ( write-only )  \ event generation register
TIM6 $24 + constant TIM6_CNT ( read-write )  \ counter
TIM6 $28 + constant TIM6_PSC ( read-write )  \ prescaler
TIM6 $2C + constant TIM6_ARR ( read-write )  \ auto-reload register
$40022000 constant Flash ( Flash ) 
Flash $0 + constant Flash_ACR (  )  \ Flash access control register
Flash $4 + constant Flash_KEYR ( write-only )  \ Flash key register
Flash $8 + constant Flash_OPTKEYR ( write-only )  \ Flash option key register
Flash $C + constant Flash_SR (  )  \ Flash status register
Flash $10 + constant Flash_CR ( read-write )  \ Flash control register
Flash $14 + constant Flash_AR ( write-only )  \ Flash address register
Flash $1C + constant Flash_OBR ( read-only )  \ Option byte register
Flash $20 + constant Flash_WRPR ( read-only )  \ Write protection register

compiletoram
