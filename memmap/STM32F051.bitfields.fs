\ STM32F0xx Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2020 and released under the GPL V2.
\ Requires: bit ( u -- u ) 1 swap lshift1-foldable ;	\ turn a bit position into a binary number.

\ CRC_DR (read-write) Reset:0xFFFFFFFF
: CRC_DR_DR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_DR ; \ CRC_DR_DR, Data register bits

\ CRC_IDR (read-write) Reset:0x00000000
: CRC_IDR_IDR ( %bbbbbbbb -- x addr ) CRC_IDR ; \ CRC_IDR_IDR, General-purpose 8-bit data register  bits

\ CRC_CR (read-write) Reset:0x00000000
: CRC_CR_RESET ( -- x addr ) 0 bit CRC_CR ; \ CRC_CR_RESET, reset bit
: CRC_CR_REV_IN ( %bb -- x addr ) 5 lshift CRC_CR ; \ CRC_CR_REV_IN, Reverse input data
: CRC_CR_REV_OUT ( -- x addr ) 7 bit CRC_CR ; \ CRC_CR_REV_OUT, Reverse output data

\ CRC_INIT (read-write) Reset:0xFFFFFFFF
: CRC_INIT_INIT ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_INIT ; \ CRC_INIT_INIT, Programmable initial CRC  value

\ GPIOF_MODER (read-write) Reset:0x00000000
: GPIOF_MODER_MODER15 ( %bb -- x addr ) 30 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER15, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER14 ( %bb -- x addr ) 28 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER14, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER13 ( %bb -- x addr ) 26 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER13, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER12 ( %bb -- x addr ) 24 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER12, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER11 ( %bb -- x addr ) 22 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER11, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER10 ( %bb -- x addr ) 20 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER10, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER9 ( %bb -- x addr ) 18 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER9, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER8 ( %bb -- x addr ) 16 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER8, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER7 ( %bb -- x addr ) 14 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER7, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER6 ( %bb -- x addr ) 12 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER6, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER5 ( %bb -- x addr ) 10 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER5, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER4 ( %bb -- x addr ) 8 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER4, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER3 ( %bb -- x addr ) 6 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER3, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER2 ( %bb -- x addr ) 4 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER2, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER1 ( %bb -- x addr ) 2 lshift GPIOF_MODER ; \ GPIOF_MODER_MODER1, Port x configuration bits y =  0..15
: GPIOF_MODER_MODER0 ( %bb -- x addr ) GPIOF_MODER ; \ GPIOF_MODER_MODER0, Port x configuration bits y =  0..15

\ GPIOF_OTYPER (read-write) Reset:0x00000000
: GPIOF_OTYPER_OT15 ( -- x addr ) 15 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT15, Port x configuration bit  15
: GPIOF_OTYPER_OT14 ( -- x addr ) 14 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT14, Port x configuration bit  14
: GPIOF_OTYPER_OT13 ( -- x addr ) 13 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT13, Port x configuration bit  13
: GPIOF_OTYPER_OT12 ( -- x addr ) 12 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT12, Port x configuration bit  12
: GPIOF_OTYPER_OT11 ( -- x addr ) 11 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT11, Port x configuration bit  11
: GPIOF_OTYPER_OT10 ( -- x addr ) 10 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT10, Port x configuration bit  10
: GPIOF_OTYPER_OT9 ( -- x addr ) 9 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT9, Port x configuration bit 9
: GPIOF_OTYPER_OT8 ( -- x addr ) 8 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT8, Port x configuration bit 8
: GPIOF_OTYPER_OT7 ( -- x addr ) 7 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT7, Port x configuration bit 7
: GPIOF_OTYPER_OT6 ( -- x addr ) 6 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT6, Port x configuration bit 6
: GPIOF_OTYPER_OT5 ( -- x addr ) 5 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT5, Port x configuration bit 5
: GPIOF_OTYPER_OT4 ( -- x addr ) 4 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT4, Port x configuration bit 4
: GPIOF_OTYPER_OT3 ( -- x addr ) 3 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT3, Port x configuration bit 3
: GPIOF_OTYPER_OT2 ( -- x addr ) 2 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT2, Port x configuration bit 2
: GPIOF_OTYPER_OT1 ( -- x addr ) 1 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT1, Port x configuration bit 1
: GPIOF_OTYPER_OT0 ( -- x addr ) 0 bit GPIOF_OTYPER ; \ GPIOF_OTYPER_OT0, Port x configuration bit 0

\ GPIOF_OSPEEDR (read-write) Reset:0x00000000
: GPIOF_OSPEEDR_OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR15, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR14, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR13, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR12, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR11, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR10, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR9, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR8, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR7, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR6, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR5, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR4, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR3, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR2, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR1, Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR0 ( %bb -- x addr ) GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR_OSPEEDR0, Port x configuration bits y =  0..15

\ GPIOF_PUPDR (read-write) Reset:0x00000000
: GPIOF_PUPDR_PUPDR15 ( %bb -- x addr ) 30 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR15, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR14 ( %bb -- x addr ) 28 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR14, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR13 ( %bb -- x addr ) 26 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR13, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR12 ( %bb -- x addr ) 24 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR12, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR11 ( %bb -- x addr ) 22 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR11, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR10 ( %bb -- x addr ) 20 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR10, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR9 ( %bb -- x addr ) 18 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR9, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR8 ( %bb -- x addr ) 16 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR8, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR7 ( %bb -- x addr ) 14 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR7, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR6 ( %bb -- x addr ) 12 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR6, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR5 ( %bb -- x addr ) 10 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR5, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR4 ( %bb -- x addr ) 8 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR4, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR3 ( %bb -- x addr ) 6 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR3, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR2 ( %bb -- x addr ) 4 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR2, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR1 ( %bb -- x addr ) 2 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR1, Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR0 ( %bb -- x addr ) GPIOF_PUPDR ; \ GPIOF_PUPDR_PUPDR0, Port x configuration bits y =  0..15

\ GPIOF_IDR (read-only) Reset:0x00000000
: GPIOF_IDR_IDR15? ( --  1|0 ) 15 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR15, Port input data y =  0..15
: GPIOF_IDR_IDR14? ( --  1|0 ) 14 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR14, Port input data y =  0..15
: GPIOF_IDR_IDR13? ( --  1|0 ) 13 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR13, Port input data y =  0..15
: GPIOF_IDR_IDR12? ( --  1|0 ) 12 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR12, Port input data y =  0..15
: GPIOF_IDR_IDR11? ( --  1|0 ) 11 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR11, Port input data y =  0..15
: GPIOF_IDR_IDR10? ( --  1|0 ) 10 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR10, Port input data y =  0..15
: GPIOF_IDR_IDR9? ( --  1|0 ) 9 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR9, Port input data y =  0..15
: GPIOF_IDR_IDR8? ( --  1|0 ) 8 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR8, Port input data y =  0..15
: GPIOF_IDR_IDR7? ( --  1|0 ) 7 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR7, Port input data y =  0..15
: GPIOF_IDR_IDR6? ( --  1|0 ) 6 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR6, Port input data y =  0..15
: GPIOF_IDR_IDR5? ( --  1|0 ) 5 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR5, Port input data y =  0..15
: GPIOF_IDR_IDR4? ( --  1|0 ) 4 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR4, Port input data y =  0..15
: GPIOF_IDR_IDR3? ( --  1|0 ) 3 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR3, Port input data y =  0..15
: GPIOF_IDR_IDR2? ( --  1|0 ) 2 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR2, Port input data y =  0..15
: GPIOF_IDR_IDR1? ( --  1|0 ) 1 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR1, Port input data y =  0..15
: GPIOF_IDR_IDR0? ( --  1|0 ) 0 bit GPIOF_IDR bit@ ; \ GPIOF_IDR_IDR0, Port input data y =  0..15

\ GPIOF_ODR (read-write) Reset:0x00000000
: GPIOF_ODR_ODR15 ( -- x addr ) 15 bit GPIOF_ODR ; \ GPIOF_ODR_ODR15, Port output data y =  0..15
: GPIOF_ODR_ODR14 ( -- x addr ) 14 bit GPIOF_ODR ; \ GPIOF_ODR_ODR14, Port output data y =  0..15
: GPIOF_ODR_ODR13 ( -- x addr ) 13 bit GPIOF_ODR ; \ GPIOF_ODR_ODR13, Port output data y =  0..15
: GPIOF_ODR_ODR12 ( -- x addr ) 12 bit GPIOF_ODR ; \ GPIOF_ODR_ODR12, Port output data y =  0..15
: GPIOF_ODR_ODR11 ( -- x addr ) 11 bit GPIOF_ODR ; \ GPIOF_ODR_ODR11, Port output data y =  0..15
: GPIOF_ODR_ODR10 ( -- x addr ) 10 bit GPIOF_ODR ; \ GPIOF_ODR_ODR10, Port output data y =  0..15
: GPIOF_ODR_ODR9 ( -- x addr ) 9 bit GPIOF_ODR ; \ GPIOF_ODR_ODR9, Port output data y =  0..15
: GPIOF_ODR_ODR8 ( -- x addr ) 8 bit GPIOF_ODR ; \ GPIOF_ODR_ODR8, Port output data y =  0..15
: GPIOF_ODR_ODR7 ( -- x addr ) 7 bit GPIOF_ODR ; \ GPIOF_ODR_ODR7, Port output data y =  0..15
: GPIOF_ODR_ODR6 ( -- x addr ) 6 bit GPIOF_ODR ; \ GPIOF_ODR_ODR6, Port output data y =  0..15
: GPIOF_ODR_ODR5 ( -- x addr ) 5 bit GPIOF_ODR ; \ GPIOF_ODR_ODR5, Port output data y =  0..15
: GPIOF_ODR_ODR4 ( -- x addr ) 4 bit GPIOF_ODR ; \ GPIOF_ODR_ODR4, Port output data y =  0..15
: GPIOF_ODR_ODR3 ( -- x addr ) 3 bit GPIOF_ODR ; \ GPIOF_ODR_ODR3, Port output data y =  0..15
: GPIOF_ODR_ODR2 ( -- x addr ) 2 bit GPIOF_ODR ; \ GPIOF_ODR_ODR2, Port output data y =  0..15
: GPIOF_ODR_ODR1 ( -- x addr ) 1 bit GPIOF_ODR ; \ GPIOF_ODR_ODR1, Port output data y =  0..15
: GPIOF_ODR_ODR0 ( -- x addr ) 0 bit GPIOF_ODR ; \ GPIOF_ODR_ODR0, Port output data y =  0..15

\ GPIOF_BSRR (write-only) Reset:0x00000000
: GPIOF_BSRR_BR15 ( -- ) 31 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR14 ( -- ) 30 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR13 ( -- ) 29 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR12 ( -- ) 28 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR11 ( -- ) 27 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR10 ( -- ) 26 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR9 ( -- ) 25 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR8 ( -- ) 24 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR7 ( -- ) 23 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR6 ( -- ) 22 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR5 ( -- ) 21 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR4 ( -- ) 20 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR3 ( -- ) 19 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR2 ( -- ) 18 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR1 ( -- ) 17 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOF_BSRR_BR0 ( -- ) 16 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BR0, Port x set bit y y=  0..15
: GPIOF_BSRR_BS15 ( -- ) 15 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS15, Port x set bit y y=  0..15
: GPIOF_BSRR_BS14 ( -- ) 14 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS14, Port x set bit y y=  0..15
: GPIOF_BSRR_BS13 ( -- ) 13 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS13, Port x set bit y y=  0..15
: GPIOF_BSRR_BS12 ( -- ) 12 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS12, Port x set bit y y=  0..15
: GPIOF_BSRR_BS11 ( -- ) 11 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS11, Port x set bit y y=  0..15
: GPIOF_BSRR_BS10 ( -- ) 10 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS10, Port x set bit y y=  0..15
: GPIOF_BSRR_BS9 ( -- ) 9 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS9, Port x set bit y y=  0..15
: GPIOF_BSRR_BS8 ( -- ) 8 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS8, Port x set bit y y=  0..15
: GPIOF_BSRR_BS7 ( -- ) 7 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS7, Port x set bit y y=  0..15
: GPIOF_BSRR_BS6 ( -- ) 6 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS6, Port x set bit y y=  0..15
: GPIOF_BSRR_BS5 ( -- ) 5 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS5, Port x set bit y y=  0..15
: GPIOF_BSRR_BS4 ( -- ) 4 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS4, Port x set bit y y=  0..15
: GPIOF_BSRR_BS3 ( -- ) 3 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS3, Port x set bit y y=  0..15
: GPIOF_BSRR_BS2 ( -- ) 2 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS2, Port x set bit y y=  0..15
: GPIOF_BSRR_BS1 ( -- ) 1 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS1, Port x set bit y y=  0..15
: GPIOF_BSRR_BS0 ( -- ) 0 bit GPIOF_BSRR ! ; \ GPIOF_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOF_LCKR (read-write) Reset:0x00000000
: GPIOF_LCKR_LCKK ( -- x addr ) 16 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCKK, Port x lock bit y
: GPIOF_LCKR_LCK15 ( -- x addr ) 15 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK14 ( -- x addr ) 14 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK13 ( -- x addr ) 13 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK12 ( -- x addr ) 12 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK11 ( -- x addr ) 11 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK10 ( -- x addr ) 10 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK9 ( -- x addr ) 9 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK8 ( -- x addr ) 8 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK7 ( -- x addr ) 7 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK6 ( -- x addr ) 6 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK5 ( -- x addr ) 5 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK4 ( -- x addr ) 4 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK3 ( -- x addr ) 3 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK2 ( -- x addr ) 2 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK1 ( -- x addr ) 1 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK0 ( -- x addr ) 0 bit GPIOF_LCKR ; \ GPIOF_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOF_AFRL (read-write) Reset:0x00000000
: GPIOF_AFRL_AFRL7 ( %bbbb -- x addr ) 28 lshift GPIOF_AFRL ; \ GPIOF_AFRL_AFRL7, Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL6 ( %bbbb -- x addr ) 24 lshift GPIOF_AFRL ; \ GPIOF_AFRL_AFRL6, Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL5 ( %bbbb -- x addr ) 20 lshift GPIOF_AFRL ; \ GPIOF_AFRL_AFRL5, Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL4 ( %bbbb -- x addr ) 16 lshift GPIOF_AFRL ; \ GPIOF_AFRL_AFRL4, Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL3 ( %bbbb -- x addr ) 12 lshift GPIOF_AFRL ; \ GPIOF_AFRL_AFRL3, Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL2 ( %bbbb -- x addr ) 8 lshift GPIOF_AFRL ; \ GPIOF_AFRL_AFRL2, Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL1 ( %bbbb -- x addr ) 4 lshift GPIOF_AFRL ; \ GPIOF_AFRL_AFRL1, Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL0 ( %bbbb -- x addr ) GPIOF_AFRL ; \ GPIOF_AFRL_AFRL0, Alternate function selection for port x  bit y y = 0..7

\ GPIOF_AFRH (read-write) Reset:0x00000000
: GPIOF_AFRH_AFRH15 ( %bbbb -- x addr ) 28 lshift GPIOF_AFRH ; \ GPIOF_AFRH_AFRH15, Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH14 ( %bbbb -- x addr ) 24 lshift GPIOF_AFRH ; \ GPIOF_AFRH_AFRH14, Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH13 ( %bbbb -- x addr ) 20 lshift GPIOF_AFRH ; \ GPIOF_AFRH_AFRH13, Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH12 ( %bbbb -- x addr ) 16 lshift GPIOF_AFRH ; \ GPIOF_AFRH_AFRH12, Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH11 ( %bbbb -- x addr ) 12 lshift GPIOF_AFRH ; \ GPIOF_AFRH_AFRH11, Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH10 ( %bbbb -- x addr ) 8 lshift GPIOF_AFRH ; \ GPIOF_AFRH_AFRH10, Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH9 ( %bbbb -- x addr ) 4 lshift GPIOF_AFRH ; \ GPIOF_AFRH_AFRH9, Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH8 ( %bbbb -- x addr ) GPIOF_AFRH ; \ GPIOF_AFRH_AFRH8, Alternate function selection for port x  bit y y = 8..15

\ GPIOF_BRR (write-only) Reset:0x00000000
: GPIOF_BRR_BR0 ( -- ) 0 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR0, Port x Reset bit y
: GPIOF_BRR_BR1 ( -- ) 1 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR1, Port x Reset bit y
: GPIOF_BRR_BR2 ( -- ) 2 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR2, Port x Reset bit y
: GPIOF_BRR_BR3 ( -- ) 3 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR3, Port x Reset bit y
: GPIOF_BRR_BR4 ( -- ) 4 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR4, Port x Reset bit y
: GPIOF_BRR_BR5 ( -- ) 5 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR5, Port x Reset bit y
: GPIOF_BRR_BR6 ( -- ) 6 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR6, Port x Reset bit y
: GPIOF_BRR_BR7 ( -- ) 7 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR7, Port x Reset bit y
: GPIOF_BRR_BR8 ( -- ) 8 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR8, Port x Reset bit y
: GPIOF_BRR_BR9 ( -- ) 9 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR9, Port x Reset bit y
: GPIOF_BRR_BR10 ( -- ) 10 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR10, Port x Reset bit y
: GPIOF_BRR_BR11 ( -- ) 11 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR11, Port x Reset bit y
: GPIOF_BRR_BR12 ( -- ) 12 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR12, Port x Reset bit y
: GPIOF_BRR_BR13 ( -- ) 13 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR13, Port x Reset bit y
: GPIOF_BRR_BR14 ( -- ) 14 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR14, Port x Reset bit y
: GPIOF_BRR_BR15 ( -- ) 15 bit GPIOF_BRR ! ; \ GPIOF_BRR_BR15, Port x Reset bit y

\ GPIOD_MODER (read-write) Reset:0x00000000
: GPIOD_MODER_MODER15 ( %bb -- x addr ) 30 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER15, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER14 ( %bb -- x addr ) 28 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER14, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER13 ( %bb -- x addr ) 26 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER13, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER12 ( %bb -- x addr ) 24 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER12, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER11 ( %bb -- x addr ) 22 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER11, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER10 ( %bb -- x addr ) 20 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER10, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER9 ( %bb -- x addr ) 18 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER9, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER8 ( %bb -- x addr ) 16 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER8, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER7 ( %bb -- x addr ) 14 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER7, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER6 ( %bb -- x addr ) 12 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER6, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER5 ( %bb -- x addr ) 10 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER5, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER4 ( %bb -- x addr ) 8 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER4, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER3 ( %bb -- x addr ) 6 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER3, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER2 ( %bb -- x addr ) 4 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER2, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER1 ( %bb -- x addr ) 2 lshift GPIOD_MODER ; \ GPIOD_MODER_MODER1, Port x configuration bits y =  0..15
: GPIOD_MODER_MODER0 ( %bb -- x addr ) GPIOD_MODER ; \ GPIOD_MODER_MODER0, Port x configuration bits y =  0..15

\ GPIOD_OTYPER (read-write) Reset:0x00000000
: GPIOD_OTYPER_OT15 ( -- x addr ) 15 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT15, Port x configuration bit  15
: GPIOD_OTYPER_OT14 ( -- x addr ) 14 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT14, Port x configuration bit  14
: GPIOD_OTYPER_OT13 ( -- x addr ) 13 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT13, Port x configuration bit  13
: GPIOD_OTYPER_OT12 ( -- x addr ) 12 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT12, Port x configuration bit  12
: GPIOD_OTYPER_OT11 ( -- x addr ) 11 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT11, Port x configuration bit  11
: GPIOD_OTYPER_OT10 ( -- x addr ) 10 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT10, Port x configuration bit  10
: GPIOD_OTYPER_OT9 ( -- x addr ) 9 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT9, Port x configuration bit 9
: GPIOD_OTYPER_OT8 ( -- x addr ) 8 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT8, Port x configuration bit 8
: GPIOD_OTYPER_OT7 ( -- x addr ) 7 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT7, Port x configuration bit 7
: GPIOD_OTYPER_OT6 ( -- x addr ) 6 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT6, Port x configuration bit 6
: GPIOD_OTYPER_OT5 ( -- x addr ) 5 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT5, Port x configuration bit 5
: GPIOD_OTYPER_OT4 ( -- x addr ) 4 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT4, Port x configuration bit 4
: GPIOD_OTYPER_OT3 ( -- x addr ) 3 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT3, Port x configuration bit 3
: GPIOD_OTYPER_OT2 ( -- x addr ) 2 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT2, Port x configuration bit 2
: GPIOD_OTYPER_OT1 ( -- x addr ) 1 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT1, Port x configuration bit 1
: GPIOD_OTYPER_OT0 ( -- x addr ) 0 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT0, Port x configuration bit 0

\ GPIOD_OSPEEDR (read-write) Reset:0x00000000
: GPIOD_OSPEEDR_OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR15, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR14, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR13, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR12, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR11, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR10, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR9, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR8, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR7, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR6, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR5, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR4, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR3, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR2, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR1, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR0 ( %bb -- x addr ) GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEEDR0, Port x configuration bits y =  0..15

\ GPIOD_PUPDR (read-write) Reset:0x00000000
: GPIOD_PUPDR_PUPDR15 ( %bb -- x addr ) 30 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR15, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR14 ( %bb -- x addr ) 28 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR14, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR13 ( %bb -- x addr ) 26 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR13, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR12 ( %bb -- x addr ) 24 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR12, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR11 ( %bb -- x addr ) 22 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR11, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR10 ( %bb -- x addr ) 20 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR10, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR9 ( %bb -- x addr ) 18 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR9, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR8 ( %bb -- x addr ) 16 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR8, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR7 ( %bb -- x addr ) 14 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR7, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR6 ( %bb -- x addr ) 12 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR6, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR5 ( %bb -- x addr ) 10 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR5, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR4 ( %bb -- x addr ) 8 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR4, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR3 ( %bb -- x addr ) 6 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR3, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR2 ( %bb -- x addr ) 4 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR2, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR1 ( %bb -- x addr ) 2 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR1, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR0 ( %bb -- x addr ) GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPDR0, Port x configuration bits y =  0..15

\ GPIOD_IDR (read-only) Reset:0x00000000
: GPIOD_IDR_IDR15? ( --  1|0 ) 15 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR15, Port input data y =  0..15
: GPIOD_IDR_IDR14? ( --  1|0 ) 14 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR14, Port input data y =  0..15
: GPIOD_IDR_IDR13? ( --  1|0 ) 13 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR13, Port input data y =  0..15
: GPIOD_IDR_IDR12? ( --  1|0 ) 12 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR12, Port input data y =  0..15
: GPIOD_IDR_IDR11? ( --  1|0 ) 11 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR11, Port input data y =  0..15
: GPIOD_IDR_IDR10? ( --  1|0 ) 10 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR10, Port input data y =  0..15
: GPIOD_IDR_IDR9? ( --  1|0 ) 9 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR9, Port input data y =  0..15
: GPIOD_IDR_IDR8? ( --  1|0 ) 8 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR8, Port input data y =  0..15
: GPIOD_IDR_IDR7? ( --  1|0 ) 7 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR7, Port input data y =  0..15
: GPIOD_IDR_IDR6? ( --  1|0 ) 6 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR6, Port input data y =  0..15
: GPIOD_IDR_IDR5? ( --  1|0 ) 5 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR5, Port input data y =  0..15
: GPIOD_IDR_IDR4? ( --  1|0 ) 4 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR4, Port input data y =  0..15
: GPIOD_IDR_IDR3? ( --  1|0 ) 3 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR3, Port input data y =  0..15
: GPIOD_IDR_IDR2? ( --  1|0 ) 2 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR2, Port input data y =  0..15
: GPIOD_IDR_IDR1? ( --  1|0 ) 1 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR1, Port input data y =  0..15
: GPIOD_IDR_IDR0? ( --  1|0 ) 0 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_IDR0, Port input data y =  0..15

\ GPIOD_ODR (read-write) Reset:0x00000000
: GPIOD_ODR_ODR15 ( -- x addr ) 15 bit GPIOD_ODR ; \ GPIOD_ODR_ODR15, Port output data y =  0..15
: GPIOD_ODR_ODR14 ( -- x addr ) 14 bit GPIOD_ODR ; \ GPIOD_ODR_ODR14, Port output data y =  0..15
: GPIOD_ODR_ODR13 ( -- x addr ) 13 bit GPIOD_ODR ; \ GPIOD_ODR_ODR13, Port output data y =  0..15
: GPIOD_ODR_ODR12 ( -- x addr ) 12 bit GPIOD_ODR ; \ GPIOD_ODR_ODR12, Port output data y =  0..15
: GPIOD_ODR_ODR11 ( -- x addr ) 11 bit GPIOD_ODR ; \ GPIOD_ODR_ODR11, Port output data y =  0..15
: GPIOD_ODR_ODR10 ( -- x addr ) 10 bit GPIOD_ODR ; \ GPIOD_ODR_ODR10, Port output data y =  0..15
: GPIOD_ODR_ODR9 ( -- x addr ) 9 bit GPIOD_ODR ; \ GPIOD_ODR_ODR9, Port output data y =  0..15
: GPIOD_ODR_ODR8 ( -- x addr ) 8 bit GPIOD_ODR ; \ GPIOD_ODR_ODR8, Port output data y =  0..15
: GPIOD_ODR_ODR7 ( -- x addr ) 7 bit GPIOD_ODR ; \ GPIOD_ODR_ODR7, Port output data y =  0..15
: GPIOD_ODR_ODR6 ( -- x addr ) 6 bit GPIOD_ODR ; \ GPIOD_ODR_ODR6, Port output data y =  0..15
: GPIOD_ODR_ODR5 ( -- x addr ) 5 bit GPIOD_ODR ; \ GPIOD_ODR_ODR5, Port output data y =  0..15
: GPIOD_ODR_ODR4 ( -- x addr ) 4 bit GPIOD_ODR ; \ GPIOD_ODR_ODR4, Port output data y =  0..15
: GPIOD_ODR_ODR3 ( -- x addr ) 3 bit GPIOD_ODR ; \ GPIOD_ODR_ODR3, Port output data y =  0..15
: GPIOD_ODR_ODR2 ( -- x addr ) 2 bit GPIOD_ODR ; \ GPIOD_ODR_ODR2, Port output data y =  0..15
: GPIOD_ODR_ODR1 ( -- x addr ) 1 bit GPIOD_ODR ; \ GPIOD_ODR_ODR1, Port output data y =  0..15
: GPIOD_ODR_ODR0 ( -- x addr ) 0 bit GPIOD_ODR ; \ GPIOD_ODR_ODR0, Port output data y =  0..15

\ GPIOD_BSRR (write-only) Reset:0x00000000
: GPIOD_BSRR_BR15 ( -- ) 31 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR14 ( -- ) 30 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR13 ( -- ) 29 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR12 ( -- ) 28 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR11 ( -- ) 27 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR10 ( -- ) 26 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR9 ( -- ) 25 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR8 ( -- ) 24 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR7 ( -- ) 23 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR6 ( -- ) 22 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR5 ( -- ) 21 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR4 ( -- ) 20 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR3 ( -- ) 19 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR2 ( -- ) 18 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR1 ( -- ) 17 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR0 ( -- ) 16 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR0, Port x set bit y y=  0..15
: GPIOD_BSRR_BS15 ( -- ) 15 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS15, Port x set bit y y=  0..15
: GPIOD_BSRR_BS14 ( -- ) 14 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS14, Port x set bit y y=  0..15
: GPIOD_BSRR_BS13 ( -- ) 13 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS13, Port x set bit y y=  0..15
: GPIOD_BSRR_BS12 ( -- ) 12 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS12, Port x set bit y y=  0..15
: GPIOD_BSRR_BS11 ( -- ) 11 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS11, Port x set bit y y=  0..15
: GPIOD_BSRR_BS10 ( -- ) 10 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS10, Port x set bit y y=  0..15
: GPIOD_BSRR_BS9 ( -- ) 9 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS9, Port x set bit y y=  0..15
: GPIOD_BSRR_BS8 ( -- ) 8 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS8, Port x set bit y y=  0..15
: GPIOD_BSRR_BS7 ( -- ) 7 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS7, Port x set bit y y=  0..15
: GPIOD_BSRR_BS6 ( -- ) 6 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS6, Port x set bit y y=  0..15
: GPIOD_BSRR_BS5 ( -- ) 5 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS5, Port x set bit y y=  0..15
: GPIOD_BSRR_BS4 ( -- ) 4 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS4, Port x set bit y y=  0..15
: GPIOD_BSRR_BS3 ( -- ) 3 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS3, Port x set bit y y=  0..15
: GPIOD_BSRR_BS2 ( -- ) 2 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS2, Port x set bit y y=  0..15
: GPIOD_BSRR_BS1 ( -- ) 1 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS1, Port x set bit y y=  0..15
: GPIOD_BSRR_BS0 ( -- ) 0 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOD_LCKR (read-write) Reset:0x00000000
: GPIOD_LCKR_LCKK ( -- x addr ) 16 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCKK, Port x lock bit y
: GPIOD_LCKR_LCK15 ( -- x addr ) 15 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK14 ( -- x addr ) 14 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK13 ( -- x addr ) 13 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK12 ( -- x addr ) 12 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK11 ( -- x addr ) 11 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK10 ( -- x addr ) 10 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK9 ( -- x addr ) 9 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK8 ( -- x addr ) 8 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK7 ( -- x addr ) 7 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK6 ( -- x addr ) 6 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK5 ( -- x addr ) 5 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK4 ( -- x addr ) 4 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK3 ( -- x addr ) 3 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK2 ( -- x addr ) 2 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK1 ( -- x addr ) 1 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK0 ( -- x addr ) 0 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOD_AFRL (read-write) Reset:0x00000000
: GPIOD_AFRL_AFRL7 ( %bbbb -- x addr ) 28 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFRL7, Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL6 ( %bbbb -- x addr ) 24 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFRL6, Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL5 ( %bbbb -- x addr ) 20 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFRL5, Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL4 ( %bbbb -- x addr ) 16 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFRL4, Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL3 ( %bbbb -- x addr ) 12 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFRL3, Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL2 ( %bbbb -- x addr ) 8 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFRL2, Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL1 ( %bbbb -- x addr ) 4 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFRL1, Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL0 ( %bbbb -- x addr ) GPIOD_AFRL ; \ GPIOD_AFRL_AFRL0, Alternate function selection for port x  bit y y = 0..7

\ GPIOD_AFRH (read-write) Reset:0x00000000
: GPIOD_AFRH_AFRH15 ( %bbbb -- x addr ) 28 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFRH15, Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH14 ( %bbbb -- x addr ) 24 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFRH14, Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH13 ( %bbbb -- x addr ) 20 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFRH13, Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH12 ( %bbbb -- x addr ) 16 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFRH12, Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH11 ( %bbbb -- x addr ) 12 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFRH11, Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH10 ( %bbbb -- x addr ) 8 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFRH10, Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH9 ( %bbbb -- x addr ) 4 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFRH9, Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH8 ( %bbbb -- x addr ) GPIOD_AFRH ; \ GPIOD_AFRH_AFRH8, Alternate function selection for port x  bit y y = 8..15

\ GPIOD_BRR (write-only) Reset:0x00000000
: GPIOD_BRR_BR0 ( -- ) 0 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR0, Port x Reset bit y
: GPIOD_BRR_BR1 ( -- ) 1 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR1, Port x Reset bit y
: GPIOD_BRR_BR2 ( -- ) 2 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR2, Port x Reset bit y
: GPIOD_BRR_BR3 ( -- ) 3 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR3, Port x Reset bit y
: GPIOD_BRR_BR4 ( -- ) 4 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR4, Port x Reset bit y
: GPIOD_BRR_BR5 ( -- ) 5 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR5, Port x Reset bit y
: GPIOD_BRR_BR6 ( -- ) 6 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR6, Port x Reset bit y
: GPIOD_BRR_BR7 ( -- ) 7 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR7, Port x Reset bit y
: GPIOD_BRR_BR8 ( -- ) 8 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR8, Port x Reset bit y
: GPIOD_BRR_BR9 ( -- ) 9 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR9, Port x Reset bit y
: GPIOD_BRR_BR10 ( -- ) 10 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR10, Port x Reset bit y
: GPIOD_BRR_BR11 ( -- ) 11 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR11, Port x Reset bit y
: GPIOD_BRR_BR12 ( -- ) 12 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR12, Port x Reset bit y
: GPIOD_BRR_BR13 ( -- ) 13 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR13, Port x Reset bit y
: GPIOD_BRR_BR14 ( -- ) 14 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR14, Port x Reset bit y
: GPIOD_BRR_BR15 ( -- ) 15 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR15, Port x Reset bit y

\ GPIOC_MODER (read-write) Reset:0x00000000
: GPIOC_MODER_MODER15 ( %bb -- x addr ) 30 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER15, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER14 ( %bb -- x addr ) 28 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER14, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER13 ( %bb -- x addr ) 26 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER13, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER12 ( %bb -- x addr ) 24 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER12, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER11 ( %bb -- x addr ) 22 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER11, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER10 ( %bb -- x addr ) 20 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER10, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER9 ( %bb -- x addr ) 18 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER9, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER8 ( %bb -- x addr ) 16 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER8, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER7 ( %bb -- x addr ) 14 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER7, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER6 ( %bb -- x addr ) 12 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER6, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER5 ( %bb -- x addr ) 10 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER5, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER4 ( %bb -- x addr ) 8 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER4, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER3 ( %bb -- x addr ) 6 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER3, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER2 ( %bb -- x addr ) 4 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER2, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER1 ( %bb -- x addr ) 2 lshift GPIOC_MODER ; \ GPIOC_MODER_MODER1, Port x configuration bits y =  0..15
: GPIOC_MODER_MODER0 ( %bb -- x addr ) GPIOC_MODER ; \ GPIOC_MODER_MODER0, Port x configuration bits y =  0..15

\ GPIOC_OTYPER (read-write) Reset:0x00000000
: GPIOC_OTYPER_OT15 ( -- x addr ) 15 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT15, Port x configuration bit  15
: GPIOC_OTYPER_OT14 ( -- x addr ) 14 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT14, Port x configuration bit  14
: GPIOC_OTYPER_OT13 ( -- x addr ) 13 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT13, Port x configuration bit  13
: GPIOC_OTYPER_OT12 ( -- x addr ) 12 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT12, Port x configuration bit  12
: GPIOC_OTYPER_OT11 ( -- x addr ) 11 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT11, Port x configuration bit  11
: GPIOC_OTYPER_OT10 ( -- x addr ) 10 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT10, Port x configuration bit  10
: GPIOC_OTYPER_OT9 ( -- x addr ) 9 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT9, Port x configuration bit 9
: GPIOC_OTYPER_OT8 ( -- x addr ) 8 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT8, Port x configuration bit 8
: GPIOC_OTYPER_OT7 ( -- x addr ) 7 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT7, Port x configuration bit 7
: GPIOC_OTYPER_OT6 ( -- x addr ) 6 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT6, Port x configuration bit 6
: GPIOC_OTYPER_OT5 ( -- x addr ) 5 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT5, Port x configuration bit 5
: GPIOC_OTYPER_OT4 ( -- x addr ) 4 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT4, Port x configuration bit 4
: GPIOC_OTYPER_OT3 ( -- x addr ) 3 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT3, Port x configuration bit 3
: GPIOC_OTYPER_OT2 ( -- x addr ) 2 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT2, Port x configuration bit 2
: GPIOC_OTYPER_OT1 ( -- x addr ) 1 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT1, Port x configuration bit 1
: GPIOC_OTYPER_OT0 ( -- x addr ) 0 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT0, Port x configuration bit 0

\ GPIOC_OSPEEDR (read-write) Reset:0x00000000
: GPIOC_OSPEEDR_OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR15, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR14, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR13, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR12, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR11, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR10, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR9, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR8, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR7, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR6, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR5, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR4, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR3, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR2, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR1, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR0 ( %bb -- x addr ) GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEEDR0, Port x configuration bits y =  0..15

\ GPIOC_PUPDR (read-write) Reset:0x00000000
: GPIOC_PUPDR_PUPDR15 ( %bb -- x addr ) 30 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR15, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR14 ( %bb -- x addr ) 28 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR14, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR13 ( %bb -- x addr ) 26 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR13, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR12 ( %bb -- x addr ) 24 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR12, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR11 ( %bb -- x addr ) 22 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR11, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR10 ( %bb -- x addr ) 20 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR10, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR9 ( %bb -- x addr ) 18 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR9, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR8 ( %bb -- x addr ) 16 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR8, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR7 ( %bb -- x addr ) 14 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR7, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR6 ( %bb -- x addr ) 12 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR6, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR5 ( %bb -- x addr ) 10 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR5, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR4 ( %bb -- x addr ) 8 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR4, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR3 ( %bb -- x addr ) 6 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR3, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR2 ( %bb -- x addr ) 4 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR2, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR1 ( %bb -- x addr ) 2 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR1, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR0 ( %bb -- x addr ) GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPDR0, Port x configuration bits y =  0..15

\ GPIOC_IDR (read-only) Reset:0x00000000
: GPIOC_IDR_IDR15? ( --  1|0 ) 15 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR15, Port input data y =  0..15
: GPIOC_IDR_IDR14? ( --  1|0 ) 14 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR14, Port input data y =  0..15
: GPIOC_IDR_IDR13? ( --  1|0 ) 13 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR13, Port input data y =  0..15
: GPIOC_IDR_IDR12? ( --  1|0 ) 12 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR12, Port input data y =  0..15
: GPIOC_IDR_IDR11? ( --  1|0 ) 11 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR11, Port input data y =  0..15
: GPIOC_IDR_IDR10? ( --  1|0 ) 10 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR10, Port input data y =  0..15
: GPIOC_IDR_IDR9? ( --  1|0 ) 9 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR9, Port input data y =  0..15
: GPIOC_IDR_IDR8? ( --  1|0 ) 8 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR8, Port input data y =  0..15
: GPIOC_IDR_IDR7? ( --  1|0 ) 7 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR7, Port input data y =  0..15
: GPIOC_IDR_IDR6? ( --  1|0 ) 6 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR6, Port input data y =  0..15
: GPIOC_IDR_IDR5? ( --  1|0 ) 5 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR5, Port input data y =  0..15
: GPIOC_IDR_IDR4? ( --  1|0 ) 4 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR4, Port input data y =  0..15
: GPIOC_IDR_IDR3? ( --  1|0 ) 3 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR3, Port input data y =  0..15
: GPIOC_IDR_IDR2? ( --  1|0 ) 2 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR2, Port input data y =  0..15
: GPIOC_IDR_IDR1? ( --  1|0 ) 1 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR1, Port input data y =  0..15
: GPIOC_IDR_IDR0? ( --  1|0 ) 0 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_IDR0, Port input data y =  0..15

\ GPIOC_ODR (read-write) Reset:0x00000000
: GPIOC_ODR_ODR15 ( -- x addr ) 15 bit GPIOC_ODR ; \ GPIOC_ODR_ODR15, Port output data y =  0..15
: GPIOC_ODR_ODR14 ( -- x addr ) 14 bit GPIOC_ODR ; \ GPIOC_ODR_ODR14, Port output data y =  0..15
: GPIOC_ODR_ODR13 ( -- x addr ) 13 bit GPIOC_ODR ; \ GPIOC_ODR_ODR13, Port output data y =  0..15
: GPIOC_ODR_ODR12 ( -- x addr ) 12 bit GPIOC_ODR ; \ GPIOC_ODR_ODR12, Port output data y =  0..15
: GPIOC_ODR_ODR11 ( -- x addr ) 11 bit GPIOC_ODR ; \ GPIOC_ODR_ODR11, Port output data y =  0..15
: GPIOC_ODR_ODR10 ( -- x addr ) 10 bit GPIOC_ODR ; \ GPIOC_ODR_ODR10, Port output data y =  0..15
: GPIOC_ODR_ODR9 ( -- x addr ) 9 bit GPIOC_ODR ; \ GPIOC_ODR_ODR9, Port output data y =  0..15
: GPIOC_ODR_ODR8 ( -- x addr ) 8 bit GPIOC_ODR ; \ GPIOC_ODR_ODR8, Port output data y =  0..15
: GPIOC_ODR_ODR7 ( -- x addr ) 7 bit GPIOC_ODR ; \ GPIOC_ODR_ODR7, Port output data y =  0..15
: GPIOC_ODR_ODR6 ( -- x addr ) 6 bit GPIOC_ODR ; \ GPIOC_ODR_ODR6, Port output data y =  0..15
: GPIOC_ODR_ODR5 ( -- x addr ) 5 bit GPIOC_ODR ; \ GPIOC_ODR_ODR5, Port output data y =  0..15
: GPIOC_ODR_ODR4 ( -- x addr ) 4 bit GPIOC_ODR ; \ GPIOC_ODR_ODR4, Port output data y =  0..15
: GPIOC_ODR_ODR3 ( -- x addr ) 3 bit GPIOC_ODR ; \ GPIOC_ODR_ODR3, Port output data y =  0..15
: GPIOC_ODR_ODR2 ( -- x addr ) 2 bit GPIOC_ODR ; \ GPIOC_ODR_ODR2, Port output data y =  0..15
: GPIOC_ODR_ODR1 ( -- x addr ) 1 bit GPIOC_ODR ; \ GPIOC_ODR_ODR1, Port output data y =  0..15
: GPIOC_ODR_ODR0 ( -- x addr ) 0 bit GPIOC_ODR ; \ GPIOC_ODR_ODR0, Port output data y =  0..15

\ GPIOC_BSRR (write-only) Reset:0x00000000
: GPIOC_BSRR_BR15 ( -- ) 31 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR14 ( -- ) 30 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR13 ( -- ) 29 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR12 ( -- ) 28 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR11 ( -- ) 27 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR10 ( -- ) 26 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR9 ( -- ) 25 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR8 ( -- ) 24 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR7 ( -- ) 23 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR6 ( -- ) 22 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR5 ( -- ) 21 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR4 ( -- ) 20 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR3 ( -- ) 19 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR2 ( -- ) 18 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR1 ( -- ) 17 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR0 ( -- ) 16 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR0, Port x set bit y y=  0..15
: GPIOC_BSRR_BS15 ( -- ) 15 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS15, Port x set bit y y=  0..15
: GPIOC_BSRR_BS14 ( -- ) 14 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS14, Port x set bit y y=  0..15
: GPIOC_BSRR_BS13 ( -- ) 13 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS13, Port x set bit y y=  0..15
: GPIOC_BSRR_BS12 ( -- ) 12 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS12, Port x set bit y y=  0..15
: GPIOC_BSRR_BS11 ( -- ) 11 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS11, Port x set bit y y=  0..15
: GPIOC_BSRR_BS10 ( -- ) 10 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS10, Port x set bit y y=  0..15
: GPIOC_BSRR_BS9 ( -- ) 9 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS9, Port x set bit y y=  0..15
: GPIOC_BSRR_BS8 ( -- ) 8 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS8, Port x set bit y y=  0..15
: GPIOC_BSRR_BS7 ( -- ) 7 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS7, Port x set bit y y=  0..15
: GPIOC_BSRR_BS6 ( -- ) 6 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS6, Port x set bit y y=  0..15
: GPIOC_BSRR_BS5 ( -- ) 5 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS5, Port x set bit y y=  0..15
: GPIOC_BSRR_BS4 ( -- ) 4 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS4, Port x set bit y y=  0..15
: GPIOC_BSRR_BS3 ( -- ) 3 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS3, Port x set bit y y=  0..15
: GPIOC_BSRR_BS2 ( -- ) 2 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS2, Port x set bit y y=  0..15
: GPIOC_BSRR_BS1 ( -- ) 1 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS1, Port x set bit y y=  0..15
: GPIOC_BSRR_BS0 ( -- ) 0 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOC_LCKR (read-write) Reset:0x00000000
: GPIOC_LCKR_LCKK ( -- x addr ) 16 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCKK, Port x lock bit y
: GPIOC_LCKR_LCK15 ( -- x addr ) 15 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK14 ( -- x addr ) 14 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK13 ( -- x addr ) 13 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK12 ( -- x addr ) 12 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK11 ( -- x addr ) 11 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK10 ( -- x addr ) 10 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK9 ( -- x addr ) 9 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK8 ( -- x addr ) 8 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK7 ( -- x addr ) 7 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK6 ( -- x addr ) 6 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK5 ( -- x addr ) 5 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK4 ( -- x addr ) 4 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK3 ( -- x addr ) 3 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK2 ( -- x addr ) 2 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK1 ( -- x addr ) 1 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK0 ( -- x addr ) 0 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOC_AFRL (read-write) Reset:0x00000000
: GPIOC_AFRL_AFRL7 ( %bbbb -- x addr ) 28 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFRL7, Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL6 ( %bbbb -- x addr ) 24 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFRL6, Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL5 ( %bbbb -- x addr ) 20 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFRL5, Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL4 ( %bbbb -- x addr ) 16 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFRL4, Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL3 ( %bbbb -- x addr ) 12 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFRL3, Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL2 ( %bbbb -- x addr ) 8 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFRL2, Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL1 ( %bbbb -- x addr ) 4 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFRL1, Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL0 ( %bbbb -- x addr ) GPIOC_AFRL ; \ GPIOC_AFRL_AFRL0, Alternate function selection for port x  bit y y = 0..7

\ GPIOC_AFRH (read-write) Reset:0x00000000
: GPIOC_AFRH_AFRH15 ( %bbbb -- x addr ) 28 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFRH15, Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH14 ( %bbbb -- x addr ) 24 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFRH14, Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH13 ( %bbbb -- x addr ) 20 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFRH13, Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH12 ( %bbbb -- x addr ) 16 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFRH12, Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH11 ( %bbbb -- x addr ) 12 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFRH11, Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH10 ( %bbbb -- x addr ) 8 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFRH10, Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH9 ( %bbbb -- x addr ) 4 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFRH9, Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH8 ( %bbbb -- x addr ) GPIOC_AFRH ; \ GPIOC_AFRH_AFRH8, Alternate function selection for port x  bit y y = 8..15

\ GPIOC_BRR (write-only) Reset:0x00000000
: GPIOC_BRR_BR0 ( -- ) 0 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR0, Port x Reset bit y
: GPIOC_BRR_BR1 ( -- ) 1 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR1, Port x Reset bit y
: GPIOC_BRR_BR2 ( -- ) 2 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR2, Port x Reset bit y
: GPIOC_BRR_BR3 ( -- ) 3 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR3, Port x Reset bit y
: GPIOC_BRR_BR4 ( -- ) 4 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR4, Port x Reset bit y
: GPIOC_BRR_BR5 ( -- ) 5 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR5, Port x Reset bit y
: GPIOC_BRR_BR6 ( -- ) 6 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR6, Port x Reset bit y
: GPIOC_BRR_BR7 ( -- ) 7 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR7, Port x Reset bit y
: GPIOC_BRR_BR8 ( -- ) 8 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR8, Port x Reset bit y
: GPIOC_BRR_BR9 ( -- ) 9 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR9, Port x Reset bit y
: GPIOC_BRR_BR10 ( -- ) 10 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR10, Port x Reset bit y
: GPIOC_BRR_BR11 ( -- ) 11 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR11, Port x Reset bit y
: GPIOC_BRR_BR12 ( -- ) 12 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR12, Port x Reset bit y
: GPIOC_BRR_BR13 ( -- ) 13 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR13, Port x Reset bit y
: GPIOC_BRR_BR14 ( -- ) 14 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR14, Port x Reset bit y
: GPIOC_BRR_BR15 ( -- ) 15 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR15, Port x Reset bit y

\ GPIOB_MODER (read-write) Reset:0x00000000
: GPIOB_MODER_MODER15 ( %bb -- x addr ) 30 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER15, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER14 ( %bb -- x addr ) 28 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER14, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER13 ( %bb -- x addr ) 26 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER13, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER12 ( %bb -- x addr ) 24 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER12, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER11 ( %bb -- x addr ) 22 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER11, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER10 ( %bb -- x addr ) 20 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER10, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER9 ( %bb -- x addr ) 18 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER9, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER8 ( %bb -- x addr ) 16 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER8, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER7 ( %bb -- x addr ) 14 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER7, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER6 ( %bb -- x addr ) 12 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER6, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER5 ( %bb -- x addr ) 10 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER5, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER4 ( %bb -- x addr ) 8 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER4, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER3 ( %bb -- x addr ) 6 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER3, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER2 ( %bb -- x addr ) 4 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER2, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER1 ( %bb -- x addr ) 2 lshift GPIOB_MODER ; \ GPIOB_MODER_MODER1, Port x configuration bits y =  0..15
: GPIOB_MODER_MODER0 ( %bb -- x addr ) GPIOB_MODER ; \ GPIOB_MODER_MODER0, Port x configuration bits y =  0..15

\ GPIOB_OTYPER (read-write) Reset:0x00000000
: GPIOB_OTYPER_OT15 ( -- x addr ) 15 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT15, Port x configuration bit  15
: GPIOB_OTYPER_OT14 ( -- x addr ) 14 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT14, Port x configuration bit  14
: GPIOB_OTYPER_OT13 ( -- x addr ) 13 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT13, Port x configuration bit  13
: GPIOB_OTYPER_OT12 ( -- x addr ) 12 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT12, Port x configuration bit  12
: GPIOB_OTYPER_OT11 ( -- x addr ) 11 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT11, Port x configuration bit  11
: GPIOB_OTYPER_OT10 ( -- x addr ) 10 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT10, Port x configuration bit  10
: GPIOB_OTYPER_OT9 ( -- x addr ) 9 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT9, Port x configuration bit 9
: GPIOB_OTYPER_OT8 ( -- x addr ) 8 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT8, Port x configuration bit 8
: GPIOB_OTYPER_OT7 ( -- x addr ) 7 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT7, Port x configuration bit 7
: GPIOB_OTYPER_OT6 ( -- x addr ) 6 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT6, Port x configuration bit 6
: GPIOB_OTYPER_OT5 ( -- x addr ) 5 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT5, Port x configuration bit 5
: GPIOB_OTYPER_OT4 ( -- x addr ) 4 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT4, Port x configuration bit 4
: GPIOB_OTYPER_OT3 ( -- x addr ) 3 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT3, Port x configuration bit 3
: GPIOB_OTYPER_OT2 ( -- x addr ) 2 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT2, Port x configuration bit 2
: GPIOB_OTYPER_OT1 ( -- x addr ) 1 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT1, Port x configuration bit 1
: GPIOB_OTYPER_OT0 ( -- x addr ) 0 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT0, Port x configuration bit 0

\ GPIOB_OSPEEDR (read-write) Reset:0x00000000
: GPIOB_OSPEEDR_OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR15, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR14, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR13, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR12, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR11, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR10, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR9, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR8, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR7, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR6, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR5, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR4, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR3, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR2, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR1, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR0 ( %bb -- x addr ) GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEEDR0, Port x configuration bits y =  0..15

\ GPIOB_PUPDR (read-write) Reset:0x00000000
: GPIOB_PUPDR_PUPDR15 ( %bb -- x addr ) 30 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR15, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR14 ( %bb -- x addr ) 28 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR14, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR13 ( %bb -- x addr ) 26 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR13, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR12 ( %bb -- x addr ) 24 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR12, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR11 ( %bb -- x addr ) 22 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR11, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR10 ( %bb -- x addr ) 20 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR10, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR9 ( %bb -- x addr ) 18 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR9, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR8 ( %bb -- x addr ) 16 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR8, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR7 ( %bb -- x addr ) 14 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR7, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR6 ( %bb -- x addr ) 12 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR6, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR5 ( %bb -- x addr ) 10 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR5, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR4 ( %bb -- x addr ) 8 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR4, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR3 ( %bb -- x addr ) 6 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR3, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR2 ( %bb -- x addr ) 4 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR2, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR1 ( %bb -- x addr ) 2 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR1, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR0 ( %bb -- x addr ) GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPDR0, Port x configuration bits y =  0..15

\ GPIOB_IDR (read-only) Reset:0x00000000
: GPIOB_IDR_IDR15? ( --  1|0 ) 15 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR15, Port input data y =  0..15
: GPIOB_IDR_IDR14? ( --  1|0 ) 14 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR14, Port input data y =  0..15
: GPIOB_IDR_IDR13? ( --  1|0 ) 13 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR13, Port input data y =  0..15
: GPIOB_IDR_IDR12? ( --  1|0 ) 12 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR12, Port input data y =  0..15
: GPIOB_IDR_IDR11? ( --  1|0 ) 11 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR11, Port input data y =  0..15
: GPIOB_IDR_IDR10? ( --  1|0 ) 10 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR10, Port input data y =  0..15
: GPIOB_IDR_IDR9? ( --  1|0 ) 9 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR9, Port input data y =  0..15
: GPIOB_IDR_IDR8? ( --  1|0 ) 8 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR8, Port input data y =  0..15
: GPIOB_IDR_IDR7? ( --  1|0 ) 7 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR7, Port input data y =  0..15
: GPIOB_IDR_IDR6? ( --  1|0 ) 6 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR6, Port input data y =  0..15
: GPIOB_IDR_IDR5? ( --  1|0 ) 5 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR5, Port input data y =  0..15
: GPIOB_IDR_IDR4? ( --  1|0 ) 4 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR4, Port input data y =  0..15
: GPIOB_IDR_IDR3? ( --  1|0 ) 3 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR3, Port input data y =  0..15
: GPIOB_IDR_IDR2? ( --  1|0 ) 2 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR2, Port input data y =  0..15
: GPIOB_IDR_IDR1? ( --  1|0 ) 1 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR1, Port input data y =  0..15
: GPIOB_IDR_IDR0? ( --  1|0 ) 0 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_IDR0, Port input data y =  0..15

\ GPIOB_ODR (read-write) Reset:0x00000000
: GPIOB_ODR_ODR15 ( -- x addr ) 15 bit GPIOB_ODR ; \ GPIOB_ODR_ODR15, Port output data y =  0..15
: GPIOB_ODR_ODR14 ( -- x addr ) 14 bit GPIOB_ODR ; \ GPIOB_ODR_ODR14, Port output data y =  0..15
: GPIOB_ODR_ODR13 ( -- x addr ) 13 bit GPIOB_ODR ; \ GPIOB_ODR_ODR13, Port output data y =  0..15
: GPIOB_ODR_ODR12 ( -- x addr ) 12 bit GPIOB_ODR ; \ GPIOB_ODR_ODR12, Port output data y =  0..15
: GPIOB_ODR_ODR11 ( -- x addr ) 11 bit GPIOB_ODR ; \ GPIOB_ODR_ODR11, Port output data y =  0..15
: GPIOB_ODR_ODR10 ( -- x addr ) 10 bit GPIOB_ODR ; \ GPIOB_ODR_ODR10, Port output data y =  0..15
: GPIOB_ODR_ODR9 ( -- x addr ) 9 bit GPIOB_ODR ; \ GPIOB_ODR_ODR9, Port output data y =  0..15
: GPIOB_ODR_ODR8 ( -- x addr ) 8 bit GPIOB_ODR ; \ GPIOB_ODR_ODR8, Port output data y =  0..15
: GPIOB_ODR_ODR7 ( -- x addr ) 7 bit GPIOB_ODR ; \ GPIOB_ODR_ODR7, Port output data y =  0..15
: GPIOB_ODR_ODR6 ( -- x addr ) 6 bit GPIOB_ODR ; \ GPIOB_ODR_ODR6, Port output data y =  0..15
: GPIOB_ODR_ODR5 ( -- x addr ) 5 bit GPIOB_ODR ; \ GPIOB_ODR_ODR5, Port output data y =  0..15
: GPIOB_ODR_ODR4 ( -- x addr ) 4 bit GPIOB_ODR ; \ GPIOB_ODR_ODR4, Port output data y =  0..15
: GPIOB_ODR_ODR3 ( -- x addr ) 3 bit GPIOB_ODR ; \ GPIOB_ODR_ODR3, Port output data y =  0..15
: GPIOB_ODR_ODR2 ( -- x addr ) 2 bit GPIOB_ODR ; \ GPIOB_ODR_ODR2, Port output data y =  0..15
: GPIOB_ODR_ODR1 ( -- x addr ) 1 bit GPIOB_ODR ; \ GPIOB_ODR_ODR1, Port output data y =  0..15
: GPIOB_ODR_ODR0 ( -- x addr ) 0 bit GPIOB_ODR ; \ GPIOB_ODR_ODR0, Port output data y =  0..15

\ GPIOB_BSRR (write-only) Reset:0x00000000
: GPIOB_BSRR_BR15 ( -- ) 31 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR14 ( -- ) 30 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR13 ( -- ) 29 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR12 ( -- ) 28 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR11 ( -- ) 27 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR10 ( -- ) 26 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR9 ( -- ) 25 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR8 ( -- ) 24 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR7 ( -- ) 23 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR6 ( -- ) 22 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR5 ( -- ) 21 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR4 ( -- ) 20 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR3 ( -- ) 19 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR2 ( -- ) 18 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR1 ( -- ) 17 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR0 ( -- ) 16 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR0, Port x set bit y y=  0..15
: GPIOB_BSRR_BS15 ( -- ) 15 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS15, Port x set bit y y=  0..15
: GPIOB_BSRR_BS14 ( -- ) 14 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS14, Port x set bit y y=  0..15
: GPIOB_BSRR_BS13 ( -- ) 13 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS13, Port x set bit y y=  0..15
: GPIOB_BSRR_BS12 ( -- ) 12 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS12, Port x set bit y y=  0..15
: GPIOB_BSRR_BS11 ( -- ) 11 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS11, Port x set bit y y=  0..15
: GPIOB_BSRR_BS10 ( -- ) 10 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS10, Port x set bit y y=  0..15
: GPIOB_BSRR_BS9 ( -- ) 9 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS9, Port x set bit y y=  0..15
: GPIOB_BSRR_BS8 ( -- ) 8 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS8, Port x set bit y y=  0..15
: GPIOB_BSRR_BS7 ( -- ) 7 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS7, Port x set bit y y=  0..15
: GPIOB_BSRR_BS6 ( -- ) 6 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS6, Port x set bit y y=  0..15
: GPIOB_BSRR_BS5 ( -- ) 5 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS5, Port x set bit y y=  0..15
: GPIOB_BSRR_BS4 ( -- ) 4 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS4, Port x set bit y y=  0..15
: GPIOB_BSRR_BS3 ( -- ) 3 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS3, Port x set bit y y=  0..15
: GPIOB_BSRR_BS2 ( -- ) 2 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS2, Port x set bit y y=  0..15
: GPIOB_BSRR_BS1 ( -- ) 1 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS1, Port x set bit y y=  0..15
: GPIOB_BSRR_BS0 ( -- ) 0 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOB_LCKR (read-write) Reset:0x00000000
: GPIOB_LCKR_LCKK ( -- x addr ) 16 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCKK, Port x lock bit y
: GPIOB_LCKR_LCK15 ( -- x addr ) 15 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK14 ( -- x addr ) 14 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK13 ( -- x addr ) 13 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK12 ( -- x addr ) 12 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK11 ( -- x addr ) 11 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK10 ( -- x addr ) 10 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK9 ( -- x addr ) 9 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK8 ( -- x addr ) 8 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK7 ( -- x addr ) 7 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK6 ( -- x addr ) 6 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK5 ( -- x addr ) 5 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK4 ( -- x addr ) 4 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK3 ( -- x addr ) 3 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK2 ( -- x addr ) 2 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK1 ( -- x addr ) 1 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK0 ( -- x addr ) 0 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOB_AFRL (read-write) Reset:0x00000000
: GPIOB_AFRL_AFRL7 ( %bbbb -- x addr ) 28 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFRL7, Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL6 ( %bbbb -- x addr ) 24 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFRL6, Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL5 ( %bbbb -- x addr ) 20 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFRL5, Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL4 ( %bbbb -- x addr ) 16 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFRL4, Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL3 ( %bbbb -- x addr ) 12 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFRL3, Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL2 ( %bbbb -- x addr ) 8 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFRL2, Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL1 ( %bbbb -- x addr ) 4 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFRL1, Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL0 ( %bbbb -- x addr ) GPIOB_AFRL ; \ GPIOB_AFRL_AFRL0, Alternate function selection for port x  bit y y = 0..7

\ GPIOB_AFRH (read-write) Reset:0x00000000
: GPIOB_AFRH_AFRH15 ( %bbbb -- x addr ) 28 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFRH15, Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH14 ( %bbbb -- x addr ) 24 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFRH14, Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH13 ( %bbbb -- x addr ) 20 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFRH13, Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH12 ( %bbbb -- x addr ) 16 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFRH12, Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH11 ( %bbbb -- x addr ) 12 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFRH11, Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH10 ( %bbbb -- x addr ) 8 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFRH10, Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH9 ( %bbbb -- x addr ) 4 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFRH9, Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH8 ( %bbbb -- x addr ) GPIOB_AFRH ; \ GPIOB_AFRH_AFRH8, Alternate function selection for port x  bit y y = 8..15

\ GPIOB_BRR (write-only) Reset:0x00000000
: GPIOB_BRR_BR0 ( -- ) 0 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR0, Port x Reset bit y
: GPIOB_BRR_BR1 ( -- ) 1 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR1, Port x Reset bit y
: GPIOB_BRR_BR2 ( -- ) 2 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR2, Port x Reset bit y
: GPIOB_BRR_BR3 ( -- ) 3 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR3, Port x Reset bit y
: GPIOB_BRR_BR4 ( -- ) 4 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR4, Port x Reset bit y
: GPIOB_BRR_BR5 ( -- ) 5 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR5, Port x Reset bit y
: GPIOB_BRR_BR6 ( -- ) 6 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR6, Port x Reset bit y
: GPIOB_BRR_BR7 ( -- ) 7 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR7, Port x Reset bit y
: GPIOB_BRR_BR8 ( -- ) 8 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR8, Port x Reset bit y
: GPIOB_BRR_BR9 ( -- ) 9 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR9, Port x Reset bit y
: GPIOB_BRR_BR10 ( -- ) 10 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR10, Port x Reset bit y
: GPIOB_BRR_BR11 ( -- ) 11 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR11, Port x Reset bit y
: GPIOB_BRR_BR12 ( -- ) 12 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR12, Port x Reset bit y
: GPIOB_BRR_BR13 ( -- ) 13 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR13, Port x Reset bit y
: GPIOB_BRR_BR14 ( -- ) 14 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR14, Port x Reset bit y
: GPIOB_BRR_BR15 ( -- ) 15 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR15, Port x Reset bit y

\ GPIOE_MODER (read-write) Reset:0x00000000
: GPIOE_MODER_MODER15 ( %bb -- x addr ) 30 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER15, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER14 ( %bb -- x addr ) 28 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER14, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER13 ( %bb -- x addr ) 26 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER13, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER12 ( %bb -- x addr ) 24 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER12, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER11 ( %bb -- x addr ) 22 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER11, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER10 ( %bb -- x addr ) 20 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER10, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER9 ( %bb -- x addr ) 18 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER9, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER8 ( %bb -- x addr ) 16 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER8, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER7 ( %bb -- x addr ) 14 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER7, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER6 ( %bb -- x addr ) 12 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER6, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER5 ( %bb -- x addr ) 10 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER5, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER4 ( %bb -- x addr ) 8 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER4, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER3 ( %bb -- x addr ) 6 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER3, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER2 ( %bb -- x addr ) 4 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER2, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER1 ( %bb -- x addr ) 2 lshift GPIOE_MODER ; \ GPIOE_MODER_MODER1, Port x configuration bits y =  0..15
: GPIOE_MODER_MODER0 ( %bb -- x addr ) GPIOE_MODER ; \ GPIOE_MODER_MODER0, Port x configuration bits y =  0..15

\ GPIOE_OTYPER (read-write) Reset:0x00000000
: GPIOE_OTYPER_OT15 ( -- x addr ) 15 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT15, Port x configuration bit  15
: GPIOE_OTYPER_OT14 ( -- x addr ) 14 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT14, Port x configuration bit  14
: GPIOE_OTYPER_OT13 ( -- x addr ) 13 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT13, Port x configuration bit  13
: GPIOE_OTYPER_OT12 ( -- x addr ) 12 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT12, Port x configuration bit  12
: GPIOE_OTYPER_OT11 ( -- x addr ) 11 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT11, Port x configuration bit  11
: GPIOE_OTYPER_OT10 ( -- x addr ) 10 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT10, Port x configuration bit  10
: GPIOE_OTYPER_OT9 ( -- x addr ) 9 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT9, Port x configuration bit 9
: GPIOE_OTYPER_OT8 ( -- x addr ) 8 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT8, Port x configuration bit 8
: GPIOE_OTYPER_OT7 ( -- x addr ) 7 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT7, Port x configuration bit 7
: GPIOE_OTYPER_OT6 ( -- x addr ) 6 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT6, Port x configuration bit 6
: GPIOE_OTYPER_OT5 ( -- x addr ) 5 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT5, Port x configuration bit 5
: GPIOE_OTYPER_OT4 ( -- x addr ) 4 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT4, Port x configuration bit 4
: GPIOE_OTYPER_OT3 ( -- x addr ) 3 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT3, Port x configuration bit 3
: GPIOE_OTYPER_OT2 ( -- x addr ) 2 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT2, Port x configuration bit 2
: GPIOE_OTYPER_OT1 ( -- x addr ) 1 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT1, Port x configuration bit 1
: GPIOE_OTYPER_OT0 ( -- x addr ) 0 bit GPIOE_OTYPER ; \ GPIOE_OTYPER_OT0, Port x configuration bit 0

\ GPIOE_OSPEEDR (read-write) Reset:0x00000000
: GPIOE_OSPEEDR_OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR15, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR14, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR13, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR12, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR11, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR10, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR9, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR8, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR7, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR6, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR5, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR4, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR3, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR2, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR1, Port x configuration bits y =  0..15
: GPIOE_OSPEEDR_OSPEEDR0 ( %bb -- x addr ) GPIOE_OSPEEDR ; \ GPIOE_OSPEEDR_OSPEEDR0, Port x configuration bits y =  0..15

\ GPIOE_PUPDR (read-write) Reset:0x00000000
: GPIOE_PUPDR_PUPDR15 ( %bb -- x addr ) 30 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR15, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR14 ( %bb -- x addr ) 28 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR14, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR13 ( %bb -- x addr ) 26 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR13, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR12 ( %bb -- x addr ) 24 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR12, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR11 ( %bb -- x addr ) 22 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR11, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR10 ( %bb -- x addr ) 20 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR10, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR9 ( %bb -- x addr ) 18 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR9, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR8 ( %bb -- x addr ) 16 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR8, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR7 ( %bb -- x addr ) 14 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR7, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR6 ( %bb -- x addr ) 12 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR6, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR5 ( %bb -- x addr ) 10 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR5, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR4 ( %bb -- x addr ) 8 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR4, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR3 ( %bb -- x addr ) 6 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR3, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR2 ( %bb -- x addr ) 4 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR2, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR1 ( %bb -- x addr ) 2 lshift GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR1, Port x configuration bits y =  0..15
: GPIOE_PUPDR_PUPDR0 ( %bb -- x addr ) GPIOE_PUPDR ; \ GPIOE_PUPDR_PUPDR0, Port x configuration bits y =  0..15

\ GPIOE_IDR (read-only) Reset:0x00000000
: GPIOE_IDR_IDR15? ( --  1|0 ) 15 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR15, Port input data y =  0..15
: GPIOE_IDR_IDR14? ( --  1|0 ) 14 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR14, Port input data y =  0..15
: GPIOE_IDR_IDR13? ( --  1|0 ) 13 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR13, Port input data y =  0..15
: GPIOE_IDR_IDR12? ( --  1|0 ) 12 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR12, Port input data y =  0..15
: GPIOE_IDR_IDR11? ( --  1|0 ) 11 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR11, Port input data y =  0..15
: GPIOE_IDR_IDR10? ( --  1|0 ) 10 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR10, Port input data y =  0..15
: GPIOE_IDR_IDR9? ( --  1|0 ) 9 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR9, Port input data y =  0..15
: GPIOE_IDR_IDR8? ( --  1|0 ) 8 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR8, Port input data y =  0..15
: GPIOE_IDR_IDR7? ( --  1|0 ) 7 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR7, Port input data y =  0..15
: GPIOE_IDR_IDR6? ( --  1|0 ) 6 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR6, Port input data y =  0..15
: GPIOE_IDR_IDR5? ( --  1|0 ) 5 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR5, Port input data y =  0..15
: GPIOE_IDR_IDR4? ( --  1|0 ) 4 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR4, Port input data y =  0..15
: GPIOE_IDR_IDR3? ( --  1|0 ) 3 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR3, Port input data y =  0..15
: GPIOE_IDR_IDR2? ( --  1|0 ) 2 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR2, Port input data y =  0..15
: GPIOE_IDR_IDR1? ( --  1|0 ) 1 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR1, Port input data y =  0..15
: GPIOE_IDR_IDR0? ( --  1|0 ) 0 bit GPIOE_IDR bit@ ; \ GPIOE_IDR_IDR0, Port input data y =  0..15

\ GPIOE_ODR (read-write) Reset:0x00000000
: GPIOE_ODR_ODR15 ( -- x addr ) 15 bit GPIOE_ODR ; \ GPIOE_ODR_ODR15, Port output data y =  0..15
: GPIOE_ODR_ODR14 ( -- x addr ) 14 bit GPIOE_ODR ; \ GPIOE_ODR_ODR14, Port output data y =  0..15
: GPIOE_ODR_ODR13 ( -- x addr ) 13 bit GPIOE_ODR ; \ GPIOE_ODR_ODR13, Port output data y =  0..15
: GPIOE_ODR_ODR12 ( -- x addr ) 12 bit GPIOE_ODR ; \ GPIOE_ODR_ODR12, Port output data y =  0..15
: GPIOE_ODR_ODR11 ( -- x addr ) 11 bit GPIOE_ODR ; \ GPIOE_ODR_ODR11, Port output data y =  0..15
: GPIOE_ODR_ODR10 ( -- x addr ) 10 bit GPIOE_ODR ; \ GPIOE_ODR_ODR10, Port output data y =  0..15
: GPIOE_ODR_ODR9 ( -- x addr ) 9 bit GPIOE_ODR ; \ GPIOE_ODR_ODR9, Port output data y =  0..15
: GPIOE_ODR_ODR8 ( -- x addr ) 8 bit GPIOE_ODR ; \ GPIOE_ODR_ODR8, Port output data y =  0..15
: GPIOE_ODR_ODR7 ( -- x addr ) 7 bit GPIOE_ODR ; \ GPIOE_ODR_ODR7, Port output data y =  0..15
: GPIOE_ODR_ODR6 ( -- x addr ) 6 bit GPIOE_ODR ; \ GPIOE_ODR_ODR6, Port output data y =  0..15
: GPIOE_ODR_ODR5 ( -- x addr ) 5 bit GPIOE_ODR ; \ GPIOE_ODR_ODR5, Port output data y =  0..15
: GPIOE_ODR_ODR4 ( -- x addr ) 4 bit GPIOE_ODR ; \ GPIOE_ODR_ODR4, Port output data y =  0..15
: GPIOE_ODR_ODR3 ( -- x addr ) 3 bit GPIOE_ODR ; \ GPIOE_ODR_ODR3, Port output data y =  0..15
: GPIOE_ODR_ODR2 ( -- x addr ) 2 bit GPIOE_ODR ; \ GPIOE_ODR_ODR2, Port output data y =  0..15
: GPIOE_ODR_ODR1 ( -- x addr ) 1 bit GPIOE_ODR ; \ GPIOE_ODR_ODR1, Port output data y =  0..15
: GPIOE_ODR_ODR0 ( -- x addr ) 0 bit GPIOE_ODR ; \ GPIOE_ODR_ODR0, Port output data y =  0..15

\ GPIOE_BSRR (write-only) Reset:0x00000000
: GPIOE_BSRR_BR15 ( -- ) 31 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR14 ( -- ) 30 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR13 ( -- ) 29 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR12 ( -- ) 28 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR11 ( -- ) 27 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR10 ( -- ) 26 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR9 ( -- ) 25 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR8 ( -- ) 24 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR7 ( -- ) 23 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR6 ( -- ) 22 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR5 ( -- ) 21 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR4 ( -- ) 20 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR3 ( -- ) 19 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR2 ( -- ) 18 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR1 ( -- ) 17 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOE_BSRR_BR0 ( -- ) 16 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BR0, Port x set bit y y=  0..15
: GPIOE_BSRR_BS15 ( -- ) 15 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS15, Port x set bit y y=  0..15
: GPIOE_BSRR_BS14 ( -- ) 14 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS14, Port x set bit y y=  0..15
: GPIOE_BSRR_BS13 ( -- ) 13 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS13, Port x set bit y y=  0..15
: GPIOE_BSRR_BS12 ( -- ) 12 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS12, Port x set bit y y=  0..15
: GPIOE_BSRR_BS11 ( -- ) 11 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS11, Port x set bit y y=  0..15
: GPIOE_BSRR_BS10 ( -- ) 10 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS10, Port x set bit y y=  0..15
: GPIOE_BSRR_BS9 ( -- ) 9 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS9, Port x set bit y y=  0..15
: GPIOE_BSRR_BS8 ( -- ) 8 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS8, Port x set bit y y=  0..15
: GPIOE_BSRR_BS7 ( -- ) 7 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS7, Port x set bit y y=  0..15
: GPIOE_BSRR_BS6 ( -- ) 6 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS6, Port x set bit y y=  0..15
: GPIOE_BSRR_BS5 ( -- ) 5 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS5, Port x set bit y y=  0..15
: GPIOE_BSRR_BS4 ( -- ) 4 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS4, Port x set bit y y=  0..15
: GPIOE_BSRR_BS3 ( -- ) 3 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS3, Port x set bit y y=  0..15
: GPIOE_BSRR_BS2 ( -- ) 2 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS2, Port x set bit y y=  0..15
: GPIOE_BSRR_BS1 ( -- ) 1 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS1, Port x set bit y y=  0..15
: GPIOE_BSRR_BS0 ( -- ) 0 bit GPIOE_BSRR ! ; \ GPIOE_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOE_LCKR (read-write) Reset:0x00000000
: GPIOE_LCKR_LCKK ( -- x addr ) 16 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCKK, Port x lock bit y
: GPIOE_LCKR_LCK15 ( -- x addr ) 15 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK14 ( -- x addr ) 14 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK13 ( -- x addr ) 13 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK12 ( -- x addr ) 12 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK11 ( -- x addr ) 11 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK10 ( -- x addr ) 10 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK9 ( -- x addr ) 9 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK8 ( -- x addr ) 8 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK7 ( -- x addr ) 7 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK6 ( -- x addr ) 6 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK5 ( -- x addr ) 5 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK4 ( -- x addr ) 4 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK3 ( -- x addr ) 3 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK2 ( -- x addr ) 2 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK1 ( -- x addr ) 1 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOE_LCKR_LCK0 ( -- x addr ) 0 bit GPIOE_LCKR ; \ GPIOE_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOE_AFRL (read-write) Reset:0x00000000
: GPIOE_AFRL_AFRL7 ( %bbbb -- x addr ) 28 lshift GPIOE_AFRL ; \ GPIOE_AFRL_AFRL7, Alternate function selection for port x  bit y y = 0..7
: GPIOE_AFRL_AFRL6 ( %bbbb -- x addr ) 24 lshift GPIOE_AFRL ; \ GPIOE_AFRL_AFRL6, Alternate function selection for port x  bit y y = 0..7
: GPIOE_AFRL_AFRL5 ( %bbbb -- x addr ) 20 lshift GPIOE_AFRL ; \ GPIOE_AFRL_AFRL5, Alternate function selection for port x  bit y y = 0..7
: GPIOE_AFRL_AFRL4 ( %bbbb -- x addr ) 16 lshift GPIOE_AFRL ; \ GPIOE_AFRL_AFRL4, Alternate function selection for port x  bit y y = 0..7
: GPIOE_AFRL_AFRL3 ( %bbbb -- x addr ) 12 lshift GPIOE_AFRL ; \ GPIOE_AFRL_AFRL3, Alternate function selection for port x  bit y y = 0..7
: GPIOE_AFRL_AFRL2 ( %bbbb -- x addr ) 8 lshift GPIOE_AFRL ; \ GPIOE_AFRL_AFRL2, Alternate function selection for port x  bit y y = 0..7
: GPIOE_AFRL_AFRL1 ( %bbbb -- x addr ) 4 lshift GPIOE_AFRL ; \ GPIOE_AFRL_AFRL1, Alternate function selection for port x  bit y y = 0..7
: GPIOE_AFRL_AFRL0 ( %bbbb -- x addr ) GPIOE_AFRL ; \ GPIOE_AFRL_AFRL0, Alternate function selection for port x  bit y y = 0..7

\ GPIOE_AFRH (read-write) Reset:0x00000000
: GPIOE_AFRH_AFRH15 ( %bbbb -- x addr ) 28 lshift GPIOE_AFRH ; \ GPIOE_AFRH_AFRH15, Alternate function selection for port x  bit y y = 8..15
: GPIOE_AFRH_AFRH14 ( %bbbb -- x addr ) 24 lshift GPIOE_AFRH ; \ GPIOE_AFRH_AFRH14, Alternate function selection for port x  bit y y = 8..15
: GPIOE_AFRH_AFRH13 ( %bbbb -- x addr ) 20 lshift GPIOE_AFRH ; \ GPIOE_AFRH_AFRH13, Alternate function selection for port x  bit y y = 8..15
: GPIOE_AFRH_AFRH12 ( %bbbb -- x addr ) 16 lshift GPIOE_AFRH ; \ GPIOE_AFRH_AFRH12, Alternate function selection for port x  bit y y = 8..15
: GPIOE_AFRH_AFRH11 ( %bbbb -- x addr ) 12 lshift GPIOE_AFRH ; \ GPIOE_AFRH_AFRH11, Alternate function selection for port x  bit y y = 8..15
: GPIOE_AFRH_AFRH10 ( %bbbb -- x addr ) 8 lshift GPIOE_AFRH ; \ GPIOE_AFRH_AFRH10, Alternate function selection for port x  bit y y = 8..15
: GPIOE_AFRH_AFRH9 ( %bbbb -- x addr ) 4 lshift GPIOE_AFRH ; \ GPIOE_AFRH_AFRH9, Alternate function selection for port x  bit y y = 8..15
: GPIOE_AFRH_AFRH8 ( %bbbb -- x addr ) GPIOE_AFRH ; \ GPIOE_AFRH_AFRH8, Alternate function selection for port x  bit y y = 8..15

\ GPIOE_BRR (write-only) Reset:0x00000000
: GPIOE_BRR_BR0 ( -- ) 0 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR0, Port x Reset bit y
: GPIOE_BRR_BR1 ( -- ) 1 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR1, Port x Reset bit y
: GPIOE_BRR_BR2 ( -- ) 2 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR2, Port x Reset bit y
: GPIOE_BRR_BR3 ( -- ) 3 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR3, Port x Reset bit y
: GPIOE_BRR_BR4 ( -- ) 4 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR4, Port x Reset bit y
: GPIOE_BRR_BR5 ( -- ) 5 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR5, Port x Reset bit y
: GPIOE_BRR_BR6 ( -- ) 6 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR6, Port x Reset bit y
: GPIOE_BRR_BR7 ( -- ) 7 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR7, Port x Reset bit y
: GPIOE_BRR_BR8 ( -- ) 8 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR8, Port x Reset bit y
: GPIOE_BRR_BR9 ( -- ) 9 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR9, Port x Reset bit y
: GPIOE_BRR_BR10 ( -- ) 10 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR10, Port x Reset bit y
: GPIOE_BRR_BR11 ( -- ) 11 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR11, Port x Reset bit y
: GPIOE_BRR_BR12 ( -- ) 12 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR12, Port x Reset bit y
: GPIOE_BRR_BR13 ( -- ) 13 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR13, Port x Reset bit y
: GPIOE_BRR_BR14 ( -- ) 14 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR14, Port x Reset bit y
: GPIOE_BRR_BR15 ( -- ) 15 bit GPIOE_BRR ! ; \ GPIOE_BRR_BR15, Port x Reset bit y

\ GPIOA_MODER (read-write) Reset:0x28000000
: GPIOA_MODER_MODER15 ( %bb -- x addr ) 30 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER15, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER14 ( %bb -- x addr ) 28 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER14, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER13 ( %bb -- x addr ) 26 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER13, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER12 ( %bb -- x addr ) 24 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER12, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER11 ( %bb -- x addr ) 22 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER11, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER10 ( %bb -- x addr ) 20 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER10, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER9 ( %bb -- x addr ) 18 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER9, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER8 ( %bb -- x addr ) 16 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER8, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER7 ( %bb -- x addr ) 14 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER7, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER6 ( %bb -- x addr ) 12 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER6, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER5 ( %bb -- x addr ) 10 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER5, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER4 ( %bb -- x addr ) 8 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER4, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER3 ( %bb -- x addr ) 6 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER3, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER2 ( %bb -- x addr ) 4 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER2, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER1 ( %bb -- x addr ) 2 lshift GPIOA_MODER ; \ GPIOA_MODER_MODER1, Port x configuration bits y =  0..15
: GPIOA_MODER_MODER0 ( %bb -- x addr ) GPIOA_MODER ; \ GPIOA_MODER_MODER0, Port x configuration bits y =  0..15

\ GPIOA_OTYPER (read-write) Reset:0x00000000
: GPIOA_OTYPER_OT15 ( -- x addr ) 15 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT15, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT14 ( -- x addr ) 14 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT14, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT13 ( -- x addr ) 13 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT13, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT12 ( -- x addr ) 12 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT12, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT11 ( -- x addr ) 11 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT11, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT10 ( -- x addr ) 10 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT10, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT9 ( -- x addr ) 9 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT9, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT8 ( -- x addr ) 8 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT8, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT7 ( -- x addr ) 7 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT7, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT6 ( -- x addr ) 6 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT6, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT5 ( -- x addr ) 5 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT5, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT4 ( -- x addr ) 4 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT4, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT3 ( -- x addr ) 3 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT3, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT2 ( -- x addr ) 2 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT2, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT1 ( -- x addr ) 1 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT1, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT0 ( -- x addr ) 0 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT0, Port x configuration bits y =  0..15

\ GPIOA_OSPEEDR (read-write) Reset:0x00000000
: GPIOA_OSPEEDR_OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR15, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR14, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR13, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR12, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR11, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR10, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR9, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR8, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR7, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR6, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR5, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR4, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR3, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR2, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR1, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR0 ( %bb -- x addr ) GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEEDR0, Port x configuration bits y =  0..15

\ GPIOA_PUPDR (read-write) Reset:0x24000000
: GPIOA_PUPDR_PUPDR15 ( %bb -- x addr ) 30 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR15, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR14 ( %bb -- x addr ) 28 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR14, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR13 ( %bb -- x addr ) 26 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR13, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR12 ( %bb -- x addr ) 24 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR12, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR11 ( %bb -- x addr ) 22 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR11, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR10 ( %bb -- x addr ) 20 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR10, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR9 ( %bb -- x addr ) 18 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR9, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR8 ( %bb -- x addr ) 16 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR8, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR7 ( %bb -- x addr ) 14 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR7, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR6 ( %bb -- x addr ) 12 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR6, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR5 ( %bb -- x addr ) 10 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR5, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR4 ( %bb -- x addr ) 8 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR4, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR3 ( %bb -- x addr ) 6 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR3, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR2 ( %bb -- x addr ) 4 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR2, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR1 ( %bb -- x addr ) 2 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR1, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR0 ( %bb -- x addr ) GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPDR0, Port x configuration bits y =  0..15

\ GPIOA_IDR (read-only) Reset:0x00000000
: GPIOA_IDR_IDR15? ( --  1|0 ) 15 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR15, Port input data y =  0..15
: GPIOA_IDR_IDR14? ( --  1|0 ) 14 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR14, Port input data y =  0..15
: GPIOA_IDR_IDR13? ( --  1|0 ) 13 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR13, Port input data y =  0..15
: GPIOA_IDR_IDR12? ( --  1|0 ) 12 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR12, Port input data y =  0..15
: GPIOA_IDR_IDR11? ( --  1|0 ) 11 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR11, Port input data y =  0..15
: GPIOA_IDR_IDR10? ( --  1|0 ) 10 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR10, Port input data y =  0..15
: GPIOA_IDR_IDR9? ( --  1|0 ) 9 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR9, Port input data y =  0..15
: GPIOA_IDR_IDR8? ( --  1|0 ) 8 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR8, Port input data y =  0..15
: GPIOA_IDR_IDR7? ( --  1|0 ) 7 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR7, Port input data y =  0..15
: GPIOA_IDR_IDR6? ( --  1|0 ) 6 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR6, Port input data y =  0..15
: GPIOA_IDR_IDR5? ( --  1|0 ) 5 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR5, Port input data y =  0..15
: GPIOA_IDR_IDR4? ( --  1|0 ) 4 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR4, Port input data y =  0..15
: GPIOA_IDR_IDR3? ( --  1|0 ) 3 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR3, Port input data y =  0..15
: GPIOA_IDR_IDR2? ( --  1|0 ) 2 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR2, Port input data y =  0..15
: GPIOA_IDR_IDR1? ( --  1|0 ) 1 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR1, Port input data y =  0..15
: GPIOA_IDR_IDR0? ( --  1|0 ) 0 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_IDR0, Port input data y =  0..15

\ GPIOA_ODR (read-write) Reset:0x00000000
: GPIOA_ODR_ODR15 ( -- x addr ) 15 bit GPIOA_ODR ; \ GPIOA_ODR_ODR15, Port output data y =  0..15
: GPIOA_ODR_ODR14 ( -- x addr ) 14 bit GPIOA_ODR ; \ GPIOA_ODR_ODR14, Port output data y =  0..15
: GPIOA_ODR_ODR13 ( -- x addr ) 13 bit GPIOA_ODR ; \ GPIOA_ODR_ODR13, Port output data y =  0..15
: GPIOA_ODR_ODR12 ( -- x addr ) 12 bit GPIOA_ODR ; \ GPIOA_ODR_ODR12, Port output data y =  0..15
: GPIOA_ODR_ODR11 ( -- x addr ) 11 bit GPIOA_ODR ; \ GPIOA_ODR_ODR11, Port output data y =  0..15
: GPIOA_ODR_ODR10 ( -- x addr ) 10 bit GPIOA_ODR ; \ GPIOA_ODR_ODR10, Port output data y =  0..15
: GPIOA_ODR_ODR9 ( -- x addr ) 9 bit GPIOA_ODR ; \ GPIOA_ODR_ODR9, Port output data y =  0..15
: GPIOA_ODR_ODR8 ( -- x addr ) 8 bit GPIOA_ODR ; \ GPIOA_ODR_ODR8, Port output data y =  0..15
: GPIOA_ODR_ODR7 ( -- x addr ) 7 bit GPIOA_ODR ; \ GPIOA_ODR_ODR7, Port output data y =  0..15
: GPIOA_ODR_ODR6 ( -- x addr ) 6 bit GPIOA_ODR ; \ GPIOA_ODR_ODR6, Port output data y =  0..15
: GPIOA_ODR_ODR5 ( -- x addr ) 5 bit GPIOA_ODR ; \ GPIOA_ODR_ODR5, Port output data y =  0..15
: GPIOA_ODR_ODR4 ( -- x addr ) 4 bit GPIOA_ODR ; \ GPIOA_ODR_ODR4, Port output data y =  0..15
: GPIOA_ODR_ODR3 ( -- x addr ) 3 bit GPIOA_ODR ; \ GPIOA_ODR_ODR3, Port output data y =  0..15
: GPIOA_ODR_ODR2 ( -- x addr ) 2 bit GPIOA_ODR ; \ GPIOA_ODR_ODR2, Port output data y =  0..15
: GPIOA_ODR_ODR1 ( -- x addr ) 1 bit GPIOA_ODR ; \ GPIOA_ODR_ODR1, Port output data y =  0..15
: GPIOA_ODR_ODR0 ( -- x addr ) 0 bit GPIOA_ODR ; \ GPIOA_ODR_ODR0, Port output data y =  0..15

\ GPIOA_BSRR (write-only) Reset:0x00000000
: GPIOA_BSRR_BR15 ( -- ) 31 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR14 ( -- ) 30 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR13 ( -- ) 29 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR12 ( -- ) 28 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR11 ( -- ) 27 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR10 ( -- ) 26 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR9 ( -- ) 25 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR8 ( -- ) 24 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR7 ( -- ) 23 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR6 ( -- ) 22 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR5 ( -- ) 21 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR4 ( -- ) 20 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR3 ( -- ) 19 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR2 ( -- ) 18 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR1 ( -- ) 17 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR0 ( -- ) 16 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR0, Port x set bit y y=  0..15
: GPIOA_BSRR_BS15 ( -- ) 15 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS15, Port x set bit y y=  0..15
: GPIOA_BSRR_BS14 ( -- ) 14 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS14, Port x set bit y y=  0..15
: GPIOA_BSRR_BS13 ( -- ) 13 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS13, Port x set bit y y=  0..15
: GPIOA_BSRR_BS12 ( -- ) 12 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS12, Port x set bit y y=  0..15
: GPIOA_BSRR_BS11 ( -- ) 11 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS11, Port x set bit y y=  0..15
: GPIOA_BSRR_BS10 ( -- ) 10 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS10, Port x set bit y y=  0..15
: GPIOA_BSRR_BS9 ( -- ) 9 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS9, Port x set bit y y=  0..15
: GPIOA_BSRR_BS8 ( -- ) 8 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS8, Port x set bit y y=  0..15
: GPIOA_BSRR_BS7 ( -- ) 7 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS7, Port x set bit y y=  0..15
: GPIOA_BSRR_BS6 ( -- ) 6 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS6, Port x set bit y y=  0..15
: GPIOA_BSRR_BS5 ( -- ) 5 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS5, Port x set bit y y=  0..15
: GPIOA_BSRR_BS4 ( -- ) 4 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS4, Port x set bit y y=  0..15
: GPIOA_BSRR_BS3 ( -- ) 3 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS3, Port x set bit y y=  0..15
: GPIOA_BSRR_BS2 ( -- ) 2 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS2, Port x set bit y y=  0..15
: GPIOA_BSRR_BS1 ( -- ) 1 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS1, Port x set bit y y=  0..15
: GPIOA_BSRR_BS0 ( -- ) 0 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOA_LCKR (read-write) Reset:0x00000000
: GPIOA_LCKR_LCKK ( -- x addr ) 16 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCKK, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK15 ( -- x addr ) 15 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK14 ( -- x addr ) 14 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK13 ( -- x addr ) 13 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK12 ( -- x addr ) 12 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK11 ( -- x addr ) 11 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK10 ( -- x addr ) 10 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK9 ( -- x addr ) 9 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK8 ( -- x addr ) 8 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK7 ( -- x addr ) 7 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK6 ( -- x addr ) 6 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK5 ( -- x addr ) 5 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK4 ( -- x addr ) 4 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK3 ( -- x addr ) 3 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK2 ( -- x addr ) 2 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK1 ( -- x addr ) 1 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK0 ( -- x addr ) 0 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOA_AFRL (read-write) Reset:0x00000000
: GPIOA_AFRL_AFRL7 ( %bbbb -- x addr ) 28 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFRL7, Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL6 ( %bbbb -- x addr ) 24 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFRL6, Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL5 ( %bbbb -- x addr ) 20 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFRL5, Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL4 ( %bbbb -- x addr ) 16 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFRL4, Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL3 ( %bbbb -- x addr ) 12 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFRL3, Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL2 ( %bbbb -- x addr ) 8 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFRL2, Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL1 ( %bbbb -- x addr ) 4 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFRL1, Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL0 ( %bbbb -- x addr ) GPIOA_AFRL ; \ GPIOA_AFRL_AFRL0, Alternate function selection for port x  bit y y = 0..7

\ GPIOA_AFRH (read-write) Reset:0x00000000
: GPIOA_AFRH_AFRH15 ( %bbbb -- x addr ) 28 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFRH15, Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH14 ( %bbbb -- x addr ) 24 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFRH14, Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH13 ( %bbbb -- x addr ) 20 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFRH13, Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH12 ( %bbbb -- x addr ) 16 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFRH12, Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH11 ( %bbbb -- x addr ) 12 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFRH11, Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH10 ( %bbbb -- x addr ) 8 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFRH10, Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH9 ( %bbbb -- x addr ) 4 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFRH9, Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH8 ( %bbbb -- x addr ) GPIOA_AFRH ; \ GPIOA_AFRH_AFRH8, Alternate function selection for port x  bit y y = 8..15

\ GPIOA_BRR (write-only) Reset:0x00000000
: GPIOA_BRR_BR0 ( -- ) 0 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR0, Port x Reset bit y
: GPIOA_BRR_BR1 ( -- ) 1 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR1, Port x Reset bit y
: GPIOA_BRR_BR2 ( -- ) 2 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR2, Port x Reset bit y
: GPIOA_BRR_BR3 ( -- ) 3 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR3, Port x Reset bit y
: GPIOA_BRR_BR4 ( -- ) 4 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR4, Port x Reset bit y
: GPIOA_BRR_BR5 ( -- ) 5 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR5, Port x Reset bit y
: GPIOA_BRR_BR6 ( -- ) 6 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR6, Port x Reset bit y
: GPIOA_BRR_BR7 ( -- ) 7 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR7, Port x Reset bit y
: GPIOA_BRR_BR8 ( -- ) 8 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR8, Port x Reset bit y
: GPIOA_BRR_BR9 ( -- ) 9 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR9, Port x Reset bit y
: GPIOA_BRR_BR10 ( -- ) 10 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR10, Port x Reset bit y
: GPIOA_BRR_BR11 ( -- ) 11 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR11, Port x Reset bit y
: GPIOA_BRR_BR12 ( -- ) 12 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR12, Port x Reset bit y
: GPIOA_BRR_BR13 ( -- ) 13 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR13, Port x Reset bit y
: GPIOA_BRR_BR14 ( -- ) 14 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR14, Port x Reset bit y
: GPIOA_BRR_BR15 ( -- ) 15 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR15, Port x Reset bit y

\ TIM1_CR1 (read-write) Reset:0x0000
: TIM1_CR1_CKD ( %bb -- x addr ) 8 lshift TIM1_CR1 ; \ TIM1_CR1_CKD, Clock division
: TIM1_CR1_ARPE ( -- x addr ) 7 bit TIM1_CR1 ; \ TIM1_CR1_ARPE, Auto-reload preload enable
: TIM1_CR1_CMS ( %bb -- x addr ) 5 lshift TIM1_CR1 ; \ TIM1_CR1_CMS, Center-aligned mode  selection
: TIM1_CR1_DIR ( -- x addr ) 4 bit TIM1_CR1 ; \ TIM1_CR1_DIR, Direction
: TIM1_CR1_OPM ( -- x addr ) 3 bit TIM1_CR1 ; \ TIM1_CR1_OPM, One-pulse mode
: TIM1_CR1_URS ( -- x addr ) 2 bit TIM1_CR1 ; \ TIM1_CR1_URS, Update request source
: TIM1_CR1_UDIS ( -- x addr ) 1 bit TIM1_CR1 ; \ TIM1_CR1_UDIS, Update disable
: TIM1_CR1_CEN ( -- x addr ) 0 bit TIM1_CR1 ; \ TIM1_CR1_CEN, Counter enable

\ TIM1_CR2 (read-write) Reset:0x0000
: TIM1_CR2_OIS4 ( -- x addr ) 14 bit TIM1_CR2 ; \ TIM1_CR2_OIS4, Output Idle state 4
: TIM1_CR2_OIS3N ( -- x addr ) 13 bit TIM1_CR2 ; \ TIM1_CR2_OIS3N, Output Idle state 3
: TIM1_CR2_OIS3 ( -- x addr ) 12 bit TIM1_CR2 ; \ TIM1_CR2_OIS3, Output Idle state 3
: TIM1_CR2_OIS2N ( -- x addr ) 11 bit TIM1_CR2 ; \ TIM1_CR2_OIS2N, Output Idle state 2
: TIM1_CR2_OIS2 ( -- x addr ) 10 bit TIM1_CR2 ; \ TIM1_CR2_OIS2, Output Idle state 2
: TIM1_CR2_OIS1N ( -- x addr ) 9 bit TIM1_CR2 ; \ TIM1_CR2_OIS1N, Output Idle state 1
: TIM1_CR2_OIS1 ( -- x addr ) 8 bit TIM1_CR2 ; \ TIM1_CR2_OIS1, Output Idle state 1
: TIM1_CR2_TI1S ( -- x addr ) 7 bit TIM1_CR2 ; \ TIM1_CR2_TI1S, TI1 selection
: TIM1_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM1_CR2 ; \ TIM1_CR2_MMS, Master mode selection
: TIM1_CR2_CCDS ( -- x addr ) 3 bit TIM1_CR2 ; \ TIM1_CR2_CCDS, Capture/compare DMA  selection
: TIM1_CR2_CCUS ( -- x addr ) 2 bit TIM1_CR2 ; \ TIM1_CR2_CCUS, Capture/compare control update  selection
: TIM1_CR2_CCPC ( -- x addr ) 0 bit TIM1_CR2 ; \ TIM1_CR2_CCPC, Capture/compare preloaded  control

\ TIM1_SMCR (read-write) Reset:0x0000
: TIM1_SMCR_ETP ( -- x addr ) 15 bit TIM1_SMCR ; \ TIM1_SMCR_ETP, External trigger polarity
: TIM1_SMCR_ECE ( -- x addr ) 14 bit TIM1_SMCR ; \ TIM1_SMCR_ECE, External clock enable
: TIM1_SMCR_ETPS ( %bb -- x addr ) 12 lshift TIM1_SMCR ; \ TIM1_SMCR_ETPS, External trigger prescaler
: TIM1_SMCR_ETF ( %bbbb -- x addr ) 8 lshift TIM1_SMCR ; \ TIM1_SMCR_ETF, External trigger filter
: TIM1_SMCR_MSM ( -- x addr ) 7 bit TIM1_SMCR ; \ TIM1_SMCR_MSM, Master/Slave mode
: TIM1_SMCR_TS ( %bbb -- x addr ) 4 lshift TIM1_SMCR ; \ TIM1_SMCR_TS, Trigger selection
: TIM1_SMCR_SMS ( %bbb -- x addr ) TIM1_SMCR ; \ TIM1_SMCR_SMS, Slave mode selection

\ TIM1_DIER (read-write) Reset:0x0000
: TIM1_DIER_TDE ( -- x addr ) 14 bit TIM1_DIER ; \ TIM1_DIER_TDE, Trigger DMA request enable
: TIM1_DIER_COMDE ( -- x addr ) 13 bit TIM1_DIER ; \ TIM1_DIER_COMDE, Reserved
: TIM1_DIER_CC4DE ( -- x addr ) 12 bit TIM1_DIER ; \ TIM1_DIER_CC4DE, Capture/Compare 4 DMA request  enable
: TIM1_DIER_CC3DE ( -- x addr ) 11 bit TIM1_DIER ; \ TIM1_DIER_CC3DE, Capture/Compare 3 DMA request  enable
: TIM1_DIER_CC2DE ( -- x addr ) 10 bit TIM1_DIER ; \ TIM1_DIER_CC2DE, Capture/Compare 2 DMA request  enable
: TIM1_DIER_CC1DE ( -- x addr ) 9 bit TIM1_DIER ; \ TIM1_DIER_CC1DE, Capture/Compare 1 DMA request  enable
: TIM1_DIER_UDE ( -- x addr ) 8 bit TIM1_DIER ; \ TIM1_DIER_UDE, Update DMA request enable
: TIM1_DIER_BIE ( -- x addr ) 7 bit TIM1_DIER ; \ TIM1_DIER_BIE, Break interrupt enable
: TIM1_DIER_TIE ( -- x addr ) 6 bit TIM1_DIER ; \ TIM1_DIER_TIE, Trigger interrupt enable
: TIM1_DIER_COMIE ( -- x addr ) 5 bit TIM1_DIER ; \ TIM1_DIER_COMIE, COM interrupt enable
: TIM1_DIER_CC4IE ( -- x addr ) 4 bit TIM1_DIER ; \ TIM1_DIER_CC4IE, Capture/Compare 4 interrupt  enable
: TIM1_DIER_CC3IE ( -- x addr ) 3 bit TIM1_DIER ; \ TIM1_DIER_CC3IE, Capture/Compare 3 interrupt  enable
: TIM1_DIER_CC2IE ( -- x addr ) 2 bit TIM1_DIER ; \ TIM1_DIER_CC2IE, Capture/Compare 2 interrupt  enable
: TIM1_DIER_CC1IE ( -- x addr ) 1 bit TIM1_DIER ; \ TIM1_DIER_CC1IE, Capture/Compare 1 interrupt  enable
: TIM1_DIER_UIE ( -- x addr ) 0 bit TIM1_DIER ; \ TIM1_DIER_UIE, Update interrupt enable

\ TIM1_SR (read-write) Reset:0x0000
: TIM1_SR_CC4OF ( -- x addr ) 12 bit TIM1_SR ; \ TIM1_SR_CC4OF, Capture/Compare 4 overcapture  flag
: TIM1_SR_CC3OF ( -- x addr ) 11 bit TIM1_SR ; \ TIM1_SR_CC3OF, Capture/Compare 3 overcapture  flag
: TIM1_SR_CC2OF ( -- x addr ) 10 bit TIM1_SR ; \ TIM1_SR_CC2OF, Capture/compare 2 overcapture  flag
: TIM1_SR_CC1OF ( -- x addr ) 9 bit TIM1_SR ; \ TIM1_SR_CC1OF, Capture/Compare 1 overcapture  flag
: TIM1_SR_BIF ( -- x addr ) 7 bit TIM1_SR ; \ TIM1_SR_BIF, Break interrupt flag
: TIM1_SR_TIF ( -- x addr ) 6 bit TIM1_SR ; \ TIM1_SR_TIF, Trigger interrupt flag
: TIM1_SR_COMIF ( -- x addr ) 5 bit TIM1_SR ; \ TIM1_SR_COMIF, COM interrupt flag
: TIM1_SR_CC4IF ( -- x addr ) 4 bit TIM1_SR ; \ TIM1_SR_CC4IF, Capture/Compare 4 interrupt  flag
: TIM1_SR_CC3IF ( -- x addr ) 3 bit TIM1_SR ; \ TIM1_SR_CC3IF, Capture/Compare 3 interrupt  flag
: TIM1_SR_CC2IF ( -- x addr ) 2 bit TIM1_SR ; \ TIM1_SR_CC2IF, Capture/Compare 2 interrupt  flag
: TIM1_SR_CC1IF ( -- x addr ) 1 bit TIM1_SR ; \ TIM1_SR_CC1IF, Capture/compare 1 interrupt  flag
: TIM1_SR_UIF ( -- x addr ) 0 bit TIM1_SR ; \ TIM1_SR_UIF, Update interrupt flag

\ TIM1_EGR (write-only) Reset:0x0000
: TIM1_EGR_BG ( -- x addr ) 7 bit TIM1_EGR ; \ TIM1_EGR_BG, Break generation
: TIM1_EGR_TG ( -- x addr ) 6 bit TIM1_EGR ; \ TIM1_EGR_TG, Trigger generation
: TIM1_EGR_COMG ( -- x addr ) 5 bit TIM1_EGR ; \ TIM1_EGR_COMG, Capture/Compare control update  generation
: TIM1_EGR_CC4G ( -- x addr ) 4 bit TIM1_EGR ; \ TIM1_EGR_CC4G, Capture/compare 4  generation
: TIM1_EGR_CC3G ( -- x addr ) 3 bit TIM1_EGR ; \ TIM1_EGR_CC3G, Capture/compare 3  generation
: TIM1_EGR_CC2G ( -- x addr ) 2 bit TIM1_EGR ; \ TIM1_EGR_CC2G, Capture/compare 2  generation
: TIM1_EGR_CC1G ( -- x addr ) 1 bit TIM1_EGR ; \ TIM1_EGR_CC1G, Capture/compare 1  generation
: TIM1_EGR_UG ( -- x addr ) 0 bit TIM1_EGR ; \ TIM1_EGR_UG, Update generation

\ TIM1_CCMR1_Output (read-write) Reset:0x00000000
: TIM1_CCMR1_Output_OC2CE ( -- x addr ) 15 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC2CE, Output Compare 2 clear  enable
: TIM1_CCMR1_Output_OC2M ( %bbb -- x addr ) 12 lshift TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC2M, Output Compare 2 mode
: TIM1_CCMR1_Output_OC2PE ( -- x addr ) 11 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC2PE, Output Compare 2 preload  enable
: TIM1_CCMR1_Output_OC2FE ( -- x addr ) 10 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC2FE, Output Compare 2 fast  enable
: TIM1_CCMR1_Output_CC2S ( %bb -- x addr ) 8 lshift TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_CC2S, Capture/Compare 2  selection
: TIM1_CCMR1_Output_OC1CE ( -- x addr ) 7 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC1CE, Output Compare 1 clear  enable
: TIM1_CCMR1_Output_OC1M ( %bbb -- x addr ) 4 lshift TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC1M, Output Compare 1 mode
: TIM1_CCMR1_Output_OC1PE ( -- x addr ) 3 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC1PE, Output Compare 1 preload  enable
: TIM1_CCMR1_Output_OC1FE ( -- x addr ) 2 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_OC1FE, Output Compare 1 fast  enable
: TIM1_CCMR1_Output_CC1S ( %bb -- x addr ) TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output_CC1S, Capture/Compare 1  selection

\ TIM1_CCMR1_Input (read-write) Reset:0x00000000
: TIM1_CCMR1_Input_IC2F ( %bbbb -- x addr ) 12 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input_IC2F, Input capture 2 filter
: TIM1_CCMR1_Input_IC2PCS ( %bb -- x addr ) 10 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input_IC2PCS, Input capture 2 prescaler
: TIM1_CCMR1_Input_CC2S ( %bb -- x addr ) 8 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input_CC2S, Capture/Compare 2  selection
: TIM1_CCMR1_Input_IC1F ( %bbbb -- x addr ) 4 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input_IC1F, Input capture 1 filter
: TIM1_CCMR1_Input_IC1PCS ( %bb -- x addr ) 2 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input_IC1PCS, Input capture 1 prescaler
: TIM1_CCMR1_Input_CC1S ( %bb -- x addr ) TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input_CC1S, Capture/Compare 1  selection

\ TIM1_CCMR2_Output (read-write) Reset:0x00000000
: TIM1_CCMR2_Output_OC4CE ( -- x addr ) 15 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC4CE, Output compare 4 clear  enable
: TIM1_CCMR2_Output_OC4M ( %bbb -- x addr ) 12 lshift TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC4M, Output compare 4 mode
: TIM1_CCMR2_Output_OC4PE ( -- x addr ) 11 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC4PE, Output compare 4 preload  enable
: TIM1_CCMR2_Output_OC4FE ( -- x addr ) 10 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC4FE, Output compare 4 fast  enable
: TIM1_CCMR2_Output_CC4S ( %bb -- x addr ) 8 lshift TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_CC4S, Capture/Compare 4  selection
: TIM1_CCMR2_Output_OC3CE ( -- x addr ) 7 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC3CE, Output compare 3 clear  enable
: TIM1_CCMR2_Output_OC3M ( %bbb -- x addr ) 4 lshift TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC3M, Output compare 3 mode
: TIM1_CCMR2_Output_OC3PE ( -- x addr ) 3 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC3PE, Output compare 3 preload  enable
: TIM1_CCMR2_Output_OC3FE ( -- x addr ) 2 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_OC3FE, Output compare 3 fast  enable
: TIM1_CCMR2_Output_CC3S ( %bb -- x addr ) TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output_CC3S, Capture/Compare 3  selection

\ TIM1_CCMR2_Input (read-write) Reset:0x00000000
: TIM1_CCMR2_Input_IC4F ( %bbbb -- x addr ) 12 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input_IC4F, Input capture 4 filter
: TIM1_CCMR2_Input_IC4PSC ( %bb -- x addr ) 10 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input_IC4PSC, Input capture 4 prescaler
: TIM1_CCMR2_Input_CC4S ( %bb -- x addr ) 8 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input_CC4S, Capture/Compare 4  selection
: TIM1_CCMR2_Input_IC3F ( %bbbb -- x addr ) 4 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input_IC3F, Input capture 3 filter
: TIM1_CCMR2_Input_IC3PSC ( %bb -- x addr ) 2 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input_IC3PSC, Input capture 3 prescaler
: TIM1_CCMR2_Input_CC3S ( %bb -- x addr ) TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input_CC3S, Capture/compare 3  selection

\ TIM1_CCER (read-write) Reset:0x0000
: TIM1_CCER_CC4P ( -- x addr ) 13 bit TIM1_CCER ; \ TIM1_CCER_CC4P, Capture/Compare 3 output  Polarity
: TIM1_CCER_CC4E ( -- x addr ) 12 bit TIM1_CCER ; \ TIM1_CCER_CC4E, Capture/Compare 4 output  enable
: TIM1_CCER_CC3NP ( -- x addr ) 11 bit TIM1_CCER ; \ TIM1_CCER_CC3NP, Capture/Compare 3 output  Polarity
: TIM1_CCER_CC3NE ( -- x addr ) 10 bit TIM1_CCER ; \ TIM1_CCER_CC3NE, Capture/Compare 3 complementary output  enable
: TIM1_CCER_CC3P ( -- x addr ) 9 bit TIM1_CCER ; \ TIM1_CCER_CC3P, Capture/Compare 3 output  Polarity
: TIM1_CCER_CC3E ( -- x addr ) 8 bit TIM1_CCER ; \ TIM1_CCER_CC3E, Capture/Compare 3 output  enable
: TIM1_CCER_CC2NP ( -- x addr ) 7 bit TIM1_CCER ; \ TIM1_CCER_CC2NP, Capture/Compare 2 output  Polarity
: TIM1_CCER_CC2NE ( -- x addr ) 6 bit TIM1_CCER ; \ TIM1_CCER_CC2NE, Capture/Compare 2 complementary output  enable
: TIM1_CCER_CC2P ( -- x addr ) 5 bit TIM1_CCER ; \ TIM1_CCER_CC2P, Capture/Compare 2 output  Polarity
: TIM1_CCER_CC2E ( -- x addr ) 4 bit TIM1_CCER ; \ TIM1_CCER_CC2E, Capture/Compare 2 output  enable
: TIM1_CCER_CC1NP ( -- x addr ) 3 bit TIM1_CCER ; \ TIM1_CCER_CC1NP, Capture/Compare 1 output  Polarity
: TIM1_CCER_CC1NE ( -- x addr ) 2 bit TIM1_CCER ; \ TIM1_CCER_CC1NE, Capture/Compare 1 complementary output  enable
: TIM1_CCER_CC1P ( -- x addr ) 1 bit TIM1_CCER ; \ TIM1_CCER_CC1P, Capture/Compare 1 output  Polarity
: TIM1_CCER_CC1E ( -- x addr ) 0 bit TIM1_CCER ; \ TIM1_CCER_CC1E, Capture/Compare 1 output  enable

\ TIM1_CNT (read-write) Reset:0x00000000
: TIM1_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CNT ; \ TIM1_CNT_CNT, counter value

\ TIM1_PSC (read-write) Reset:0x0000
: TIM1_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_PSC ; \ TIM1_PSC_PSC, Prescaler value

\ TIM1_ARR (read-write) Reset:0x00000000
: TIM1_ARR_ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_ARR ; \ TIM1_ARR_ARR, Auto-reload value

\ TIM1_RCR (read-write) Reset:0x0000
: TIM1_RCR_REP ( %bbbbbbbb -- x addr ) TIM1_RCR ; \ TIM1_RCR_REP, Repetition counter value

\ TIM1_CCR1 (read-write) Reset:0x00000000
: TIM1_CCR1_CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR1 ; \ TIM1_CCR1_CCR1, Capture/Compare 1 value

\ TIM1_CCR2 (read-write) Reset:0x00000000
: TIM1_CCR2_CCR2 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR2 ; \ TIM1_CCR2_CCR2, Capture/Compare 2 value

\ TIM1_CCR3 (read-write) Reset:0x00000000
: TIM1_CCR3_CCR3 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR3 ; \ TIM1_CCR3_CCR3, Capture/Compare 3 value

\ TIM1_CCR4 (read-write) Reset:0x00000000
: TIM1_CCR4_CCR4 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR4 ; \ TIM1_CCR4_CCR4, Capture/Compare 3 value

\ TIM1_BDTR (read-write) Reset:0x0000
: TIM1_BDTR_MOE ( -- x addr ) 15 bit TIM1_BDTR ; \ TIM1_BDTR_MOE, Main output enable
: TIM1_BDTR_AOE ( -- x addr ) 14 bit TIM1_BDTR ; \ TIM1_BDTR_AOE, Automatic output enable
: TIM1_BDTR_BKP ( -- x addr ) 13 bit TIM1_BDTR ; \ TIM1_BDTR_BKP, Break polarity
: TIM1_BDTR_BKE ( -- x addr ) 12 bit TIM1_BDTR ; \ TIM1_BDTR_BKE, Break enable
: TIM1_BDTR_OSSR ( -- x addr ) 11 bit TIM1_BDTR ; \ TIM1_BDTR_OSSR, Off-state selection for Run  mode
: TIM1_BDTR_OSSI ( -- x addr ) 10 bit TIM1_BDTR ; \ TIM1_BDTR_OSSI, Off-state selection for Idle  mode
: TIM1_BDTR_LOCK ( %bb -- x addr ) 8 lshift TIM1_BDTR ; \ TIM1_BDTR_LOCK, Lock configuration
: TIM1_BDTR_DTG ( %bbbbbbbb -- x addr ) TIM1_BDTR ; \ TIM1_BDTR_DTG, Dead-time generator setup

\ TIM1_DCR (read-write) Reset:0x0000
: TIM1_DCR_DBL ( %bbbbb -- x addr ) 8 lshift TIM1_DCR ; \ TIM1_DCR_DBL, DMA burst length
: TIM1_DCR_DBA ( %bbbbb -- x addr ) TIM1_DCR ; \ TIM1_DCR_DBA, DMA base address

\ TIM1_DMAR (read-write) Reset:0x0000
: TIM1_DMAR_DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_DMAR ; \ TIM1_DMAR_DMAB, DMA register for burst  accesses

\ TIM2_CR1 (read-write) Reset:0x0000
: TIM2_CR1_CKD ( %bb -- x addr ) 8 lshift TIM2_CR1 ; \ TIM2_CR1_CKD, Clock division
: TIM2_CR1_ARPE ( -- x addr ) 7 bit TIM2_CR1 ; \ TIM2_CR1_ARPE, Auto-reload preload enable
: TIM2_CR1_CMS ( %bb -- x addr ) 5 lshift TIM2_CR1 ; \ TIM2_CR1_CMS, Center-aligned mode  selection
: TIM2_CR1_DIR ( -- x addr ) 4 bit TIM2_CR1 ; \ TIM2_CR1_DIR, Direction
: TIM2_CR1_OPM ( -- x addr ) 3 bit TIM2_CR1 ; \ TIM2_CR1_OPM, One-pulse mode
: TIM2_CR1_URS ( -- x addr ) 2 bit TIM2_CR1 ; \ TIM2_CR1_URS, Update request source
: TIM2_CR1_UDIS ( -- x addr ) 1 bit TIM2_CR1 ; \ TIM2_CR1_UDIS, Update disable
: TIM2_CR1_CEN ( -- x addr ) 0 bit TIM2_CR1 ; \ TIM2_CR1_CEN, Counter enable

\ TIM2_CR2 (read-write) Reset:0x0000
: TIM2_CR2_TI1S ( -- x addr ) 7 bit TIM2_CR2 ; \ TIM2_CR2_TI1S, TI1 selection
: TIM2_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM2_CR2 ; \ TIM2_CR2_MMS, Master mode selection
: TIM2_CR2_CCDS ( -- x addr ) 3 bit TIM2_CR2 ; \ TIM2_CR2_CCDS, Capture/compare DMA  selection

\ TIM2_SMCR (read-write) Reset:0x0000
: TIM2_SMCR_ETP ( -- x addr ) 15 bit TIM2_SMCR ; \ TIM2_SMCR_ETP, External trigger polarity
: TIM2_SMCR_ECE ( -- x addr ) 14 bit TIM2_SMCR ; \ TIM2_SMCR_ECE, External clock enable
: TIM2_SMCR_ETPS ( %bb -- x addr ) 12 lshift TIM2_SMCR ; \ TIM2_SMCR_ETPS, External trigger prescaler
: TIM2_SMCR_ETF ( %bbbb -- x addr ) 8 lshift TIM2_SMCR ; \ TIM2_SMCR_ETF, External trigger filter
: TIM2_SMCR_MSM ( -- x addr ) 7 bit TIM2_SMCR ; \ TIM2_SMCR_MSM, Master/Slave mode
: TIM2_SMCR_TS ( %bbb -- x addr ) 4 lshift TIM2_SMCR ; \ TIM2_SMCR_TS, Trigger selection
: TIM2_SMCR_SMS ( %bbb -- x addr ) TIM2_SMCR ; \ TIM2_SMCR_SMS, Slave mode selection

\ TIM2_DIER (read-write) Reset:0x0000
: TIM2_DIER_TDE ( -- x addr ) 14 bit TIM2_DIER ; \ TIM2_DIER_TDE, Trigger DMA request enable
: TIM2_DIER_COMDE ( -- x addr ) 13 bit TIM2_DIER ; \ TIM2_DIER_COMDE, Reserved
: TIM2_DIER_CC4DE ( -- x addr ) 12 bit TIM2_DIER ; \ TIM2_DIER_CC4DE, Capture/Compare 4 DMA request  enable
: TIM2_DIER_CC3DE ( -- x addr ) 11 bit TIM2_DIER ; \ TIM2_DIER_CC3DE, Capture/Compare 3 DMA request  enable
: TIM2_DIER_CC2DE ( -- x addr ) 10 bit TIM2_DIER ; \ TIM2_DIER_CC2DE, Capture/Compare 2 DMA request  enable
: TIM2_DIER_CC1DE ( -- x addr ) 9 bit TIM2_DIER ; \ TIM2_DIER_CC1DE, Capture/Compare 1 DMA request  enable
: TIM2_DIER_UDE ( -- x addr ) 8 bit TIM2_DIER ; \ TIM2_DIER_UDE, Update DMA request enable
: TIM2_DIER_TIE ( -- x addr ) 6 bit TIM2_DIER ; \ TIM2_DIER_TIE, Trigger interrupt enable
: TIM2_DIER_CC4IE ( -- x addr ) 4 bit TIM2_DIER ; \ TIM2_DIER_CC4IE, Capture/Compare 4 interrupt  enable
: TIM2_DIER_CC3IE ( -- x addr ) 3 bit TIM2_DIER ; \ TIM2_DIER_CC3IE, Capture/Compare 3 interrupt  enable
: TIM2_DIER_CC2IE ( -- x addr ) 2 bit TIM2_DIER ; \ TIM2_DIER_CC2IE, Capture/Compare 2 interrupt  enable
: TIM2_DIER_CC1IE ( -- x addr ) 1 bit TIM2_DIER ; \ TIM2_DIER_CC1IE, Capture/Compare 1 interrupt  enable
: TIM2_DIER_UIE ( -- x addr ) 0 bit TIM2_DIER ; \ TIM2_DIER_UIE, Update interrupt enable

\ TIM2_SR (read-write) Reset:0x0000
: TIM2_SR_CC4OF ( -- x addr ) 12 bit TIM2_SR ; \ TIM2_SR_CC4OF, Capture/Compare 4 overcapture  flag
: TIM2_SR_CC3OF ( -- x addr ) 11 bit TIM2_SR ; \ TIM2_SR_CC3OF, Capture/Compare 3 overcapture  flag
: TIM2_SR_CC2OF ( -- x addr ) 10 bit TIM2_SR ; \ TIM2_SR_CC2OF, Capture/compare 2 overcapture  flag
: TIM2_SR_CC1OF ( -- x addr ) 9 bit TIM2_SR ; \ TIM2_SR_CC1OF, Capture/Compare 1 overcapture  flag
: TIM2_SR_TIF ( -- x addr ) 6 bit TIM2_SR ; \ TIM2_SR_TIF, Trigger interrupt flag
: TIM2_SR_CC4IF ( -- x addr ) 4 bit TIM2_SR ; \ TIM2_SR_CC4IF, Capture/Compare 4 interrupt  flag
: TIM2_SR_CC3IF ( -- x addr ) 3 bit TIM2_SR ; \ TIM2_SR_CC3IF, Capture/Compare 3 interrupt  flag
: TIM2_SR_CC2IF ( -- x addr ) 2 bit TIM2_SR ; \ TIM2_SR_CC2IF, Capture/Compare 2 interrupt  flag
: TIM2_SR_CC1IF ( -- x addr ) 1 bit TIM2_SR ; \ TIM2_SR_CC1IF, Capture/compare 1 interrupt  flag
: TIM2_SR_UIF ( -- x addr ) 0 bit TIM2_SR ; \ TIM2_SR_UIF, Update interrupt flag

\ TIM2_EGR (write-only) Reset:0x0000
: TIM2_EGR_TG ( -- x addr ) 6 bit TIM2_EGR ; \ TIM2_EGR_TG, Trigger generation
: TIM2_EGR_CC4G ( -- x addr ) 4 bit TIM2_EGR ; \ TIM2_EGR_CC4G, Capture/compare 4  generation
: TIM2_EGR_CC3G ( -- x addr ) 3 bit TIM2_EGR ; \ TIM2_EGR_CC3G, Capture/compare 3  generation
: TIM2_EGR_CC2G ( -- x addr ) 2 bit TIM2_EGR ; \ TIM2_EGR_CC2G, Capture/compare 2  generation
: TIM2_EGR_CC1G ( -- x addr ) 1 bit TIM2_EGR ; \ TIM2_EGR_CC1G, Capture/compare 1  generation
: TIM2_EGR_UG ( -- x addr ) 0 bit TIM2_EGR ; \ TIM2_EGR_UG, Update generation

\ TIM2_CCMR1_Output (read-write) Reset:0x00000000
: TIM2_CCMR1_Output_OC2CE ( -- x addr ) 15 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2CE, Output compare 2 clear  enable
: TIM2_CCMR1_Output_OC2M ( %bbb -- x addr ) 12 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2M, Output compare 2 mode
: TIM2_CCMR1_Output_OC2PE ( -- x addr ) 11 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2PE, Output compare 2 preload  enable
: TIM2_CCMR1_Output_OC2FE ( -- x addr ) 10 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2FE, Output compare 2 fast  enable
: TIM2_CCMR1_Output_CC2S ( %bb -- x addr ) 8 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_CC2S, Capture/Compare 2  selection
: TIM2_CCMR1_Output_OC1CE ( -- x addr ) 7 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1CE, Output compare 1 clear  enable
: TIM2_CCMR1_Output_OC1M ( %bbb -- x addr ) 4 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1M, Output compare 1 mode
: TIM2_CCMR1_Output_OC1PE ( -- x addr ) 3 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1PE, Output compare 1 preload  enable
: TIM2_CCMR1_Output_OC1FE ( -- x addr ) 2 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1FE, Output compare 1 fast  enable
: TIM2_CCMR1_Output_CC1S ( %bb -- x addr ) TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_CC1S, Capture/Compare 1  selection

\ TIM2_CCMR1_Input (read-write) Reset:0x00000000
: TIM2_CCMR1_Input_IC2F ( %bbbb -- x addr ) 12 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC2F, Input capture 2 filter
: TIM2_CCMR1_Input_IC2PSC ( %bb -- x addr ) 10 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC2PSC, Input capture 2 prescaler
: TIM2_CCMR1_Input_CC2S ( %bb -- x addr ) 8 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_CC2S, Capture/compare 2  selection
: TIM2_CCMR1_Input_IC1F ( %bbbb -- x addr ) 4 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC1F, Input capture 1 filter
: TIM2_CCMR1_Input_IC1PSC ( %bb -- x addr ) 2 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC1PSC, Input capture 1 prescaler
: TIM2_CCMR1_Input_CC1S ( %bb -- x addr ) TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_CC1S, Capture/Compare 1  selection

\ TIM2_CCMR2_Output (read-write) Reset:0x00000000
: TIM2_CCMR2_Output_OC4CE ( -- x addr ) 15 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4CE, Output compare 4 clear  enable
: TIM2_CCMR2_Output_OC4M ( %bbb -- x addr ) 12 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4M, Output compare 4 mode
: TIM2_CCMR2_Output_OC4PE ( -- x addr ) 11 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4PE, Output compare 4 preload  enable
: TIM2_CCMR2_Output_OC4FE ( -- x addr ) 10 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4FE, Output compare 4 fast  enable
: TIM2_CCMR2_Output_CC4S ( %bb -- x addr ) 8 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_CC4S, Capture/Compare 4  selection
: TIM2_CCMR2_Output_OC3CE ( -- x addr ) 7 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3CE, Output compare 3 clear  enable
: TIM2_CCMR2_Output_OC3M ( %bbb -- x addr ) 4 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3M, Output compare 3 mode
: TIM2_CCMR2_Output_OC3PE ( -- x addr ) 3 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3PE, Output compare 3 preload  enable
: TIM2_CCMR2_Output_OC3FE ( -- x addr ) 2 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3FE, Output compare 3 fast  enable
: TIM2_CCMR2_Output_CC3S ( %bb -- x addr ) TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_CC3S, Capture/Compare 3  selection

\ TIM2_CCMR2_Input (read-write) Reset:0x00000000
: TIM2_CCMR2_Input_IC4F ( %bbbb -- x addr ) 12 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC4F, Input capture 4 filter
: TIM2_CCMR2_Input_IC4PSC ( %bb -- x addr ) 10 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC4PSC, Input capture 4 prescaler
: TIM2_CCMR2_Input_CC4S ( %bb -- x addr ) 8 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_CC4S, Capture/Compare 4  selection
: TIM2_CCMR2_Input_IC3F ( %bbbb -- x addr ) 4 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC3F, Input capture 3 filter
: TIM2_CCMR2_Input_IC3PSC ( %bb -- x addr ) 2 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC3PSC, Input capture 3 prescaler
: TIM2_CCMR2_Input_CC3S ( %bb -- x addr ) TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_CC3S, Capture/Compare 3  selection

\ TIM2_CCER (read-write) Reset:0x0000
: TIM2_CCER_CC4NP ( -- x addr ) 15 bit TIM2_CCER ; \ TIM2_CCER_CC4NP, Capture/Compare 4 output  Polarity
: TIM2_CCER_CC4P ( -- x addr ) 13 bit TIM2_CCER ; \ TIM2_CCER_CC4P, Capture/Compare 3 output  Polarity
: TIM2_CCER_CC4E ( -- x addr ) 12 bit TIM2_CCER ; \ TIM2_CCER_CC4E, Capture/Compare 4 output  enable
: TIM2_CCER_CC3NP ( -- x addr ) 11 bit TIM2_CCER ; \ TIM2_CCER_CC3NP, Capture/Compare 3 output  Polarity
: TIM2_CCER_CC3P ( -- x addr ) 9 bit TIM2_CCER ; \ TIM2_CCER_CC3P, Capture/Compare 3 output  Polarity
: TIM2_CCER_CC3E ( -- x addr ) 8 bit TIM2_CCER ; \ TIM2_CCER_CC3E, Capture/Compare 3 output  enable
: TIM2_CCER_CC2NP ( -- x addr ) 7 bit TIM2_CCER ; \ TIM2_CCER_CC2NP, Capture/Compare 2 output  Polarity
: TIM2_CCER_CC2P ( -- x addr ) 5 bit TIM2_CCER ; \ TIM2_CCER_CC2P, Capture/Compare 2 output  Polarity
: TIM2_CCER_CC2E ( -- x addr ) 4 bit TIM2_CCER ; \ TIM2_CCER_CC2E, Capture/Compare 2 output  enable
: TIM2_CCER_CC1NP ( -- x addr ) 3 bit TIM2_CCER ; \ TIM2_CCER_CC1NP, Capture/Compare 1 output  Polarity
: TIM2_CCER_CC1P ( -- x addr ) 1 bit TIM2_CCER ; \ TIM2_CCER_CC1P, Capture/Compare 1 output  Polarity
: TIM2_CCER_CC1E ( -- x addr ) 0 bit TIM2_CCER ; \ TIM2_CCER_CC1E, Capture/Compare 1 output  enable

\ TIM2_CNT (read-write) Reset:0x00000000
: TIM2_CNT_CNT_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CNT ; \ TIM2_CNT_CNT_H, High counter value TIM2  only
: TIM2_CNT_CNT_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CNT ; \ TIM2_CNT_CNT_L, Low counter value

\ TIM2_PSC (read-write) Reset:0x0000
: TIM2_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_PSC ; \ TIM2_PSC_PSC, Prescaler value

\ TIM2_ARR (read-write) Reset:0x00000000
: TIM2_ARR_ARR_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_ARR ; \ TIM2_ARR_ARR_H, High Auto-reload value TIM2  only
: TIM2_ARR_ARR_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_ARR ; \ TIM2_ARR_ARR_L, Low Auto-reload value

\ TIM2_CCR1 (read-write) Reset:0x00000000
: TIM2_CCR1_CCR1_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR1 ; \ TIM2_CCR1_CCR1_H, High Capture/Compare 1 value TIM2  only
: TIM2_CCR1_CCR1_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR1 ; \ TIM2_CCR1_CCR1_L, Low Capture/Compare 1  value

\ TIM2_CCR2 (read-write) Reset:0x00000000
: TIM2_CCR2_CCR2_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR2 ; \ TIM2_CCR2_CCR2_H, High Capture/Compare 2 value TIM2  only
: TIM2_CCR2_CCR2_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR2 ; \ TIM2_CCR2_CCR2_L, Low Capture/Compare 2  value

\ TIM2_CCR3 (read-write) Reset:0x00000000
: TIM2_CCR3_CCR3_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR3 ; \ TIM2_CCR3_CCR3_H, High Capture/Compare value TIM2  only
: TIM2_CCR3_CCR3_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR3 ; \ TIM2_CCR3_CCR3_L, Low Capture/Compare value

\ TIM2_CCR4 (read-write) Reset:0x00000000
: TIM2_CCR4_CCR4_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR4 ; \ TIM2_CCR4_CCR4_H, High Capture/Compare value TIM2  only
: TIM2_CCR4_CCR4_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR4 ; \ TIM2_CCR4_CCR4_L, Low Capture/Compare value

\ TIM2_DCR (read-write) Reset:0x0000
: TIM2_DCR_DBL ( %bbbbb -- x addr ) 8 lshift TIM2_DCR ; \ TIM2_DCR_DBL, DMA burst length
: TIM2_DCR_DBA ( %bbbbb -- x addr ) TIM2_DCR ; \ TIM2_DCR_DBA, DMA base address

\ TIM2_DMAR (read-write) Reset:0x0000
: TIM2_DMAR_DMAR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_DMAR ; \ TIM2_DMAR_DMAR, DMA register for burst  accesses

\ TIM3_CR1 (read-write) Reset:0x0000
: TIM3_CR1_CKD ( %bb -- x addr ) 8 lshift TIM3_CR1 ; \ TIM3_CR1_CKD, Clock division
: TIM3_CR1_ARPE ( -- x addr ) 7 bit TIM3_CR1 ; \ TIM3_CR1_ARPE, Auto-reload preload enable
: TIM3_CR1_CMS ( %bb -- x addr ) 5 lshift TIM3_CR1 ; \ TIM3_CR1_CMS, Center-aligned mode  selection
: TIM3_CR1_DIR ( -- x addr ) 4 bit TIM3_CR1 ; \ TIM3_CR1_DIR, Direction
: TIM3_CR1_OPM ( -- x addr ) 3 bit TIM3_CR1 ; \ TIM3_CR1_OPM, One-pulse mode
: TIM3_CR1_URS ( -- x addr ) 2 bit TIM3_CR1 ; \ TIM3_CR1_URS, Update request source
: TIM3_CR1_UDIS ( -- x addr ) 1 bit TIM3_CR1 ; \ TIM3_CR1_UDIS, Update disable
: TIM3_CR1_CEN ( -- x addr ) 0 bit TIM3_CR1 ; \ TIM3_CR1_CEN, Counter enable

\ TIM3_CR2 (read-write) Reset:0x0000
: TIM3_CR2_TI1S ( -- x addr ) 7 bit TIM3_CR2 ; \ TIM3_CR2_TI1S, TI1 selection
: TIM3_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM3_CR2 ; \ TIM3_CR2_MMS, Master mode selection
: TIM3_CR2_CCDS ( -- x addr ) 3 bit TIM3_CR2 ; \ TIM3_CR2_CCDS, Capture/compare DMA  selection

\ TIM3_SMCR (read-write) Reset:0x0000
: TIM3_SMCR_ETP ( -- x addr ) 15 bit TIM3_SMCR ; \ TIM3_SMCR_ETP, External trigger polarity
: TIM3_SMCR_ECE ( -- x addr ) 14 bit TIM3_SMCR ; \ TIM3_SMCR_ECE, External clock enable
: TIM3_SMCR_ETPS ( %bb -- x addr ) 12 lshift TIM3_SMCR ; \ TIM3_SMCR_ETPS, External trigger prescaler
: TIM3_SMCR_ETF ( %bbbb -- x addr ) 8 lshift TIM3_SMCR ; \ TIM3_SMCR_ETF, External trigger filter
: TIM3_SMCR_MSM ( -- x addr ) 7 bit TIM3_SMCR ; \ TIM3_SMCR_MSM, Master/Slave mode
: TIM3_SMCR_TS ( %bbb -- x addr ) 4 lshift TIM3_SMCR ; \ TIM3_SMCR_TS, Trigger selection
: TIM3_SMCR_SMS ( %bbb -- x addr ) TIM3_SMCR ; \ TIM3_SMCR_SMS, Slave mode selection

\ TIM3_DIER (read-write) Reset:0x0000
: TIM3_DIER_TDE ( -- x addr ) 14 bit TIM3_DIER ; \ TIM3_DIER_TDE, Trigger DMA request enable
: TIM3_DIER_COMDE ( -- x addr ) 13 bit TIM3_DIER ; \ TIM3_DIER_COMDE, Reserved
: TIM3_DIER_CC4DE ( -- x addr ) 12 bit TIM3_DIER ; \ TIM3_DIER_CC4DE, Capture/Compare 4 DMA request  enable
: TIM3_DIER_CC3DE ( -- x addr ) 11 bit TIM3_DIER ; \ TIM3_DIER_CC3DE, Capture/Compare 3 DMA request  enable
: TIM3_DIER_CC2DE ( -- x addr ) 10 bit TIM3_DIER ; \ TIM3_DIER_CC2DE, Capture/Compare 2 DMA request  enable
: TIM3_DIER_CC1DE ( -- x addr ) 9 bit TIM3_DIER ; \ TIM3_DIER_CC1DE, Capture/Compare 1 DMA request  enable
: TIM3_DIER_UDE ( -- x addr ) 8 bit TIM3_DIER ; \ TIM3_DIER_UDE, Update DMA request enable
: TIM3_DIER_TIE ( -- x addr ) 6 bit TIM3_DIER ; \ TIM3_DIER_TIE, Trigger interrupt enable
: TIM3_DIER_CC4IE ( -- x addr ) 4 bit TIM3_DIER ; \ TIM3_DIER_CC4IE, Capture/Compare 4 interrupt  enable
: TIM3_DIER_CC3IE ( -- x addr ) 3 bit TIM3_DIER ; \ TIM3_DIER_CC3IE, Capture/Compare 3 interrupt  enable
: TIM3_DIER_CC2IE ( -- x addr ) 2 bit TIM3_DIER ; \ TIM3_DIER_CC2IE, Capture/Compare 2 interrupt  enable
: TIM3_DIER_CC1IE ( -- x addr ) 1 bit TIM3_DIER ; \ TIM3_DIER_CC1IE, Capture/Compare 1 interrupt  enable
: TIM3_DIER_UIE ( -- x addr ) 0 bit TIM3_DIER ; \ TIM3_DIER_UIE, Update interrupt enable

\ TIM3_SR (read-write) Reset:0x0000
: TIM3_SR_CC4OF ( -- x addr ) 12 bit TIM3_SR ; \ TIM3_SR_CC4OF, Capture/Compare 4 overcapture  flag
: TIM3_SR_CC3OF ( -- x addr ) 11 bit TIM3_SR ; \ TIM3_SR_CC3OF, Capture/Compare 3 overcapture  flag
: TIM3_SR_CC2OF ( -- x addr ) 10 bit TIM3_SR ; \ TIM3_SR_CC2OF, Capture/compare 2 overcapture  flag
: TIM3_SR_CC1OF ( -- x addr ) 9 bit TIM3_SR ; \ TIM3_SR_CC1OF, Capture/Compare 1 overcapture  flag
: TIM3_SR_TIF ( -- x addr ) 6 bit TIM3_SR ; \ TIM3_SR_TIF, Trigger interrupt flag
: TIM3_SR_CC4IF ( -- x addr ) 4 bit TIM3_SR ; \ TIM3_SR_CC4IF, Capture/Compare 4 interrupt  flag
: TIM3_SR_CC3IF ( -- x addr ) 3 bit TIM3_SR ; \ TIM3_SR_CC3IF, Capture/Compare 3 interrupt  flag
: TIM3_SR_CC2IF ( -- x addr ) 2 bit TIM3_SR ; \ TIM3_SR_CC2IF, Capture/Compare 2 interrupt  flag
: TIM3_SR_CC1IF ( -- x addr ) 1 bit TIM3_SR ; \ TIM3_SR_CC1IF, Capture/compare 1 interrupt  flag
: TIM3_SR_UIF ( -- x addr ) 0 bit TIM3_SR ; \ TIM3_SR_UIF, Update interrupt flag

\ TIM3_EGR (write-only) Reset:0x0000
: TIM3_EGR_TG ( -- x addr ) 6 bit TIM3_EGR ; \ TIM3_EGR_TG, Trigger generation
: TIM3_EGR_CC4G ( -- x addr ) 4 bit TIM3_EGR ; \ TIM3_EGR_CC4G, Capture/compare 4  generation
: TIM3_EGR_CC3G ( -- x addr ) 3 bit TIM3_EGR ; \ TIM3_EGR_CC3G, Capture/compare 3  generation
: TIM3_EGR_CC2G ( -- x addr ) 2 bit TIM3_EGR ; \ TIM3_EGR_CC2G, Capture/compare 2  generation
: TIM3_EGR_CC1G ( -- x addr ) 1 bit TIM3_EGR ; \ TIM3_EGR_CC1G, Capture/compare 1  generation
: TIM3_EGR_UG ( -- x addr ) 0 bit TIM3_EGR ; \ TIM3_EGR_UG, Update generation

\ TIM3_CCMR1_Output (read-write) Reset:0x00000000
: TIM3_CCMR1_Output_OC2CE ( -- x addr ) 15 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC2CE, Output compare 2 clear  enable
: TIM3_CCMR1_Output_OC2M ( %bbb -- x addr ) 12 lshift TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC2M, Output compare 2 mode
: TIM3_CCMR1_Output_OC2PE ( -- x addr ) 11 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC2PE, Output compare 2 preload  enable
: TIM3_CCMR1_Output_OC2FE ( -- x addr ) 10 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC2FE, Output compare 2 fast  enable
: TIM3_CCMR1_Output_CC2S ( %bb -- x addr ) 8 lshift TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_CC2S, Capture/Compare 2  selection
: TIM3_CCMR1_Output_OC1CE ( -- x addr ) 7 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC1CE, Output compare 1 clear  enable
: TIM3_CCMR1_Output_OC1M ( %bbb -- x addr ) 4 lshift TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC1M, Output compare 1 mode
: TIM3_CCMR1_Output_OC1PE ( -- x addr ) 3 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC1PE, Output compare 1 preload  enable
: TIM3_CCMR1_Output_OC1FE ( -- x addr ) 2 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_OC1FE, Output compare 1 fast  enable
: TIM3_CCMR1_Output_CC1S ( %bb -- x addr ) TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output_CC1S, Capture/Compare 1  selection

\ TIM3_CCMR1_Input (read-write) Reset:0x00000000
: TIM3_CCMR1_Input_IC2F ( %bbbb -- x addr ) 12 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input_IC2F, Input capture 2 filter
: TIM3_CCMR1_Input_IC2PSC ( %bb -- x addr ) 10 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input_IC2PSC, Input capture 2 prescaler
: TIM3_CCMR1_Input_CC2S ( %bb -- x addr ) 8 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input_CC2S, Capture/compare 2  selection
: TIM3_CCMR1_Input_IC1F ( %bbbb -- x addr ) 4 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input_IC1F, Input capture 1 filter
: TIM3_CCMR1_Input_IC1PSC ( %bb -- x addr ) 2 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input_IC1PSC, Input capture 1 prescaler
: TIM3_CCMR1_Input_CC1S ( %bb -- x addr ) TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input_CC1S, Capture/Compare 1  selection

\ TIM3_CCMR2_Output (read-write) Reset:0x00000000
: TIM3_CCMR2_Output_OC4CE ( -- x addr ) 15 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC4CE, Output compare 4 clear  enable
: TIM3_CCMR2_Output_OC4M ( %bbb -- x addr ) 12 lshift TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC4M, Output compare 4 mode
: TIM3_CCMR2_Output_OC4PE ( -- x addr ) 11 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC4PE, Output compare 4 preload  enable
: TIM3_CCMR2_Output_OC4FE ( -- x addr ) 10 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC4FE, Output compare 4 fast  enable
: TIM3_CCMR2_Output_CC4S ( %bb -- x addr ) 8 lshift TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_CC4S, Capture/Compare 4  selection
: TIM3_CCMR2_Output_OC3CE ( -- x addr ) 7 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC3CE, Output compare 3 clear  enable
: TIM3_CCMR2_Output_OC3M ( %bbb -- x addr ) 4 lshift TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC3M, Output compare 3 mode
: TIM3_CCMR2_Output_OC3PE ( -- x addr ) 3 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC3PE, Output compare 3 preload  enable
: TIM3_CCMR2_Output_OC3FE ( -- x addr ) 2 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_OC3FE, Output compare 3 fast  enable
: TIM3_CCMR2_Output_CC3S ( %bb -- x addr ) TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output_CC3S, Capture/Compare 3  selection

\ TIM3_CCMR2_Input (read-write) Reset:0x00000000
: TIM3_CCMR2_Input_IC4F ( %bbbb -- x addr ) 12 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input_IC4F, Input capture 4 filter
: TIM3_CCMR2_Input_IC4PSC ( %bb -- x addr ) 10 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input_IC4PSC, Input capture 4 prescaler
: TIM3_CCMR2_Input_CC4S ( %bb -- x addr ) 8 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input_CC4S, Capture/Compare 4  selection
: TIM3_CCMR2_Input_IC3F ( %bbbb -- x addr ) 4 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input_IC3F, Input capture 3 filter
: TIM3_CCMR2_Input_IC3PSC ( %bb -- x addr ) 2 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input_IC3PSC, Input capture 3 prescaler
: TIM3_CCMR2_Input_CC3S ( %bb -- x addr ) TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input_CC3S, Capture/Compare 3  selection

\ TIM3_CCER (read-write) Reset:0x0000
: TIM3_CCER_CC4NP ( -- x addr ) 15 bit TIM3_CCER ; \ TIM3_CCER_CC4NP, Capture/Compare 4 output  Polarity
: TIM3_CCER_CC4P ( -- x addr ) 13 bit TIM3_CCER ; \ TIM3_CCER_CC4P, Capture/Compare 3 output  Polarity
: TIM3_CCER_CC4E ( -- x addr ) 12 bit TIM3_CCER ; \ TIM3_CCER_CC4E, Capture/Compare 4 output  enable
: TIM3_CCER_CC3NP ( -- x addr ) 11 bit TIM3_CCER ; \ TIM3_CCER_CC3NP, Capture/Compare 3 output  Polarity
: TIM3_CCER_CC3P ( -- x addr ) 9 bit TIM3_CCER ; \ TIM3_CCER_CC3P, Capture/Compare 3 output  Polarity
: TIM3_CCER_CC3E ( -- x addr ) 8 bit TIM3_CCER ; \ TIM3_CCER_CC3E, Capture/Compare 3 output  enable
: TIM3_CCER_CC2NP ( -- x addr ) 7 bit TIM3_CCER ; \ TIM3_CCER_CC2NP, Capture/Compare 2 output  Polarity
: TIM3_CCER_CC2P ( -- x addr ) 5 bit TIM3_CCER ; \ TIM3_CCER_CC2P, Capture/Compare 2 output  Polarity
: TIM3_CCER_CC2E ( -- x addr ) 4 bit TIM3_CCER ; \ TIM3_CCER_CC2E, Capture/Compare 2 output  enable
: TIM3_CCER_CC1NP ( -- x addr ) 3 bit TIM3_CCER ; \ TIM3_CCER_CC1NP, Capture/Compare 1 output  Polarity
: TIM3_CCER_CC1P ( -- x addr ) 1 bit TIM3_CCER ; \ TIM3_CCER_CC1P, Capture/Compare 1 output  Polarity
: TIM3_CCER_CC1E ( -- x addr ) 0 bit TIM3_CCER ; \ TIM3_CCER_CC1E, Capture/Compare 1 output  enable

\ TIM3_CNT (read-write) Reset:0x00000000
: TIM3_CNT_CNT_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CNT ; \ TIM3_CNT_CNT_H, High counter value TIM2  only
: TIM3_CNT_CNT_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CNT ; \ TIM3_CNT_CNT_L, Low counter value

\ TIM3_PSC (read-write) Reset:0x0000
: TIM3_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_PSC ; \ TIM3_PSC_PSC, Prescaler value

\ TIM3_ARR (read-write) Reset:0x00000000
: TIM3_ARR_ARR_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_ARR ; \ TIM3_ARR_ARR_H, High Auto-reload value TIM2  only
: TIM3_ARR_ARR_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_ARR ; \ TIM3_ARR_ARR_L, Low Auto-reload value

\ TIM3_CCR1 (read-write) Reset:0x00000000
: TIM3_CCR1_CCR1_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR1 ; \ TIM3_CCR1_CCR1_H, High Capture/Compare 1 value TIM2  only
: TIM3_CCR1_CCR1_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR1 ; \ TIM3_CCR1_CCR1_L, Low Capture/Compare 1  value

\ TIM3_CCR2 (read-write) Reset:0x00000000
: TIM3_CCR2_CCR2_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR2 ; \ TIM3_CCR2_CCR2_H, High Capture/Compare 2 value TIM2  only
: TIM3_CCR2_CCR2_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR2 ; \ TIM3_CCR2_CCR2_L, Low Capture/Compare 2  value

\ TIM3_CCR3 (read-write) Reset:0x00000000
: TIM3_CCR3_CCR3_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR3 ; \ TIM3_CCR3_CCR3_H, High Capture/Compare value TIM2  only
: TIM3_CCR3_CCR3_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR3 ; \ TIM3_CCR3_CCR3_L, Low Capture/Compare value

\ TIM3_CCR4 (read-write) Reset:0x00000000
: TIM3_CCR4_CCR4_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR4 ; \ TIM3_CCR4_CCR4_H, High Capture/Compare value TIM2  only
: TIM3_CCR4_CCR4_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR4 ; \ TIM3_CCR4_CCR4_L, Low Capture/Compare value

\ TIM3_DCR (read-write) Reset:0x0000
: TIM3_DCR_DBL ( %bbbbb -- x addr ) 8 lshift TIM3_DCR ; \ TIM3_DCR_DBL, DMA burst length
: TIM3_DCR_DBA ( %bbbbb -- x addr ) TIM3_DCR ; \ TIM3_DCR_DBA, DMA base address

\ TIM3_DMAR (read-write) Reset:0x0000
: TIM3_DMAR_DMAR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_DMAR ; \ TIM3_DMAR_DMAR, DMA register for burst  accesses

\ TIM6_CR1 (read-write) Reset:0x0000
: TIM6_CR1_ARPE ( -- x addr ) 7 bit TIM6_CR1 ; \ TIM6_CR1_ARPE, Auto-reload preload enable
: TIM6_CR1_OPM ( -- x addr ) 3 bit TIM6_CR1 ; \ TIM6_CR1_OPM, One-pulse mode
: TIM6_CR1_URS ( -- x addr ) 2 bit TIM6_CR1 ; \ TIM6_CR1_URS, Update request source
: TIM6_CR1_UDIS ( -- x addr ) 1 bit TIM6_CR1 ; \ TIM6_CR1_UDIS, Update disable
: TIM6_CR1_CEN ( -- x addr ) 0 bit TIM6_CR1 ; \ TIM6_CR1_CEN, Counter enable

\ TIM6_CR2 (read-write) Reset:0x0000
: TIM6_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM6_CR2 ; \ TIM6_CR2_MMS, Master mode selection

\ TIM6_DIER (read-write) Reset:0x0000
: TIM6_DIER_UDE ( -- x addr ) 8 bit TIM6_DIER ; \ TIM6_DIER_UDE, Update DMA request enable
: TIM6_DIER_UIE ( -- x addr ) 0 bit TIM6_DIER ; \ TIM6_DIER_UIE, Update interrupt enable

\ TIM6_SR (read-write) Reset:0x0000
: TIM6_SR_UIF ( -- x addr ) 0 bit TIM6_SR ; \ TIM6_SR_UIF, Update interrupt flag

\ TIM6_EGR (write-only) Reset:0x0000
: TIM6_EGR_UG ( -- x addr ) 0 bit TIM6_EGR ; \ TIM6_EGR_UG, Update generation

\ TIM6_CNT (read-write) Reset:0x00000000
: TIM6_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM6_CNT ; \ TIM6_CNT_CNT, Low counter value

\ TIM6_PSC (read-write) Reset:0x0000
: TIM6_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM6_PSC ; \ TIM6_PSC_PSC, Prescaler value

\ TIM6_ARR (read-write) Reset:0x00000000
: TIM6_ARR_ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM6_ARR ; \ TIM6_ARR_ARR, Low Auto-reload value

\ Flash_ACR (multiple-access)  Reset:0x00000030
: Flash_ACR_LATENCY ( %bbb -- x addr ) Flash_ACR ; \ Flash_ACR_LATENCY, LATENCY
: Flash_ACR_PRFTBE ( -- x addr ) 4 bit Flash_ACR ; \ Flash_ACR_PRFTBE, PRFTBE
: Flash_ACR_PRFTBS ( -- x addr ) 5 bit Flash_ACR ; \ Flash_ACR_PRFTBS, PRFTBS

\ Flash_KEYR (write-only) Reset:0x00000000
: Flash_KEYR_FKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) Flash_KEYR ; \ Flash_KEYR_FKEYR, Flash Key

\ Flash_OPTKEYR (write-only) Reset:0x00000000
: Flash_OPTKEYR_OPTKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) Flash_OPTKEYR ; \ Flash_OPTKEYR_OPTKEYR, Option byte key

\ Flash_SR (multiple-access)  Reset:0x00000000
: Flash_SR_EOP ( -- x addr ) 5 bit Flash_SR ; \ Flash_SR_EOP, End of operation
: Flash_SR_WRPRT ( -- x addr ) 4 bit Flash_SR ; \ Flash_SR_WRPRT, Write protection error
: Flash_SR_PGERR ( -- x addr ) 2 bit Flash_SR ; \ Flash_SR_PGERR, Programming error
: Flash_SR_BSY ( -- x addr ) 0 bit Flash_SR ; \ Flash_SR_BSY, Busy

\ Flash_CR (read-write) Reset:0x00000080
: Flash_CR_FORCE_OPTLOAD ( -- x addr ) 13 bit Flash_CR ; \ Flash_CR_FORCE_OPTLOAD, Force option byte loading
: Flash_CR_EOPIE ( -- x addr ) 12 bit Flash_CR ; \ Flash_CR_EOPIE, End of operation interrupt  enable
: Flash_CR_ERRIE ( -- x addr ) 10 bit Flash_CR ; \ Flash_CR_ERRIE, Error interrupt enable
: Flash_CR_OPTWRE ( -- x addr ) 9 bit Flash_CR ; \ Flash_CR_OPTWRE, Option bytes write enable
: Flash_CR_LOCK ( -- x addr ) 7 bit Flash_CR ; \ Flash_CR_LOCK, Lock
: Flash_CR_STRT ( -- x addr ) 6 bit Flash_CR ; \ Flash_CR_STRT, Start
: Flash_CR_OPTER ( -- x addr ) 5 bit Flash_CR ; \ Flash_CR_OPTER, Option byte erase
: Flash_CR_OPTPG ( -- x addr ) 4 bit Flash_CR ; \ Flash_CR_OPTPG, Option byte programming
: Flash_CR_MER ( -- x addr ) 2 bit Flash_CR ; \ Flash_CR_MER, Mass erase
: Flash_CR_PER ( -- x addr ) 1 bit Flash_CR ; \ Flash_CR_PER, Page erase
: Flash_CR_PG ( -- x addr ) 0 bit Flash_CR ; \ Flash_CR_PG, Programming

\ Flash_AR (write-only) Reset:0x00000000
: Flash_AR_FAR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) Flash_AR ; \ Flash_AR_FAR, Flash address

\ Flash_OBR (read-only) Reset:0x03FFFFF2
: Flash_OBR_Data1? ( --  x ) 24 lshift Flash_OBR @ ; \ Flash_OBR_Data1, Data1
: Flash_OBR_Data0? ( --  x ) 16 lshift Flash_OBR @ ; \ Flash_OBR_Data0, Data0
: Flash_OBR_VDDA_MONITOR? ( --  1|0 ) 13 bit Flash_OBR bit@ ; \ Flash_OBR_VDDA_MONITOR, VDDA_MONITOR
: Flash_OBR_BOOT1? ( --  1|0 ) 12 bit Flash_OBR bit@ ; \ Flash_OBR_BOOT1, BOOT1
: Flash_OBR_nRST_STDBY? ( --  1|0 ) 10 bit Flash_OBR bit@ ; \ Flash_OBR_nRST_STDBY, nRST_STDBY
: Flash_OBR_nRST_STOP? ( --  1|0 ) 9 bit Flash_OBR bit@ ; \ Flash_OBR_nRST_STOP, nRST_STOP
: Flash_OBR_WDG_SW? ( --  1|0 ) 8 bit Flash_OBR bit@ ; \ Flash_OBR_WDG_SW, WDG_SW
: Flash_OBR_LEVEL2_PROT? ( --  1|0 ) 2 bit Flash_OBR bit@ ; \ Flash_OBR_LEVEL2_PROT, Level 2 protection status
: Flash_OBR_LEVEL1_PROT? ( --  1|0 ) 1 bit Flash_OBR bit@ ; \ Flash_OBR_LEVEL1_PROT, Level 1 protection status
: Flash_OBR_OPTERR? ( --  1|0 ) 0 bit Flash_OBR bit@ ; \ Flash_OBR_OPTERR, Option byte error

\ Flash_WRPR (read-only) Reset:0xFFFFFFFF
: Flash_WRPR_WRP? ( --  x ) Flash_WRPR @ ; \ Flash_WRPR_WRP, Write protect
