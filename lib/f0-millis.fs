\ Program Name: f0-millis.fs
\ Date: Sat 12 Oct 2019 12:06:27 AEDT
\ Copyright 2019 by t.j.porter <terry@tjporter.com.au>, licensed under the GPLV2
\ This program may require preloaded support files
\ For Mecrisp-Stellaris by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Chip: STM32F051, Board: STM32F0 Discovery Board
\ Clock: 8 Mhz using the internal STM32F051 RC clock
\ All register names are CMSIS-SVD compliant
\ Note: gpio a,b,c,d,e, and uart1 are enabled by Mecrisp-Stellaris Core.
\
\ This Program : Times a event using the Systick Counter and a Interrupt.
\ Resolution is to 0.1 milliseconds. Range is 0.1 ms to 71582 minutes
\ Chip is Cortex-M0 but should work on any Cortex-M
\ ---------------------------------------------------------------------------
\ 8080 STK_RVR !    \ 1ms @ 8mhz, 808 = 0.1 mS @ 8Mhz
 
 \ define systick memory mapping as it's not included in cmsis-svd.
 \ Should work on all Cortex-M chips, check values for non Cortex-M0 chips.
 $e000e010 constant stk_csr	       \ systick control and status register. r/w reset value = $00000000
 $e000e014 constant stk_rvr	       \ systick reload value register. 
 $e000e018 constant stk_cvr	       \ systick current value register. r/w value unknown  
 $e000e01c constant stk_calib	       \ systick calibration value register. read only, $40001770 for the stm32f0

 0 variable ms_counter		       \ 32 bits or -> $ffffffff u. =  4294967295 ms, 4294967 seconds or 71582 minutes
 : tickint			       \ tickint: sysTick exception request enable
   %010 stk_csr bis!		       \ 1 = Counting down to zero asserts the SysTick exception request.
 ;

 : systick-handler
  1 ms_counter +!
 ;

 : init-systick
   808 6 * stk_rvr !		           \ systick calib for 0.1ms @ 8mhz clock, multiply by 6 for 48mhz
   %101 stk_csr bis!		       \ systick enable
   ['] systick-handler irq-systick !   \ 'hooks' the systick-handler word (above) to the systick irq
   tickint
 ;

 : pretty.print ( -- )		       \ insert one decimal point
  0 <# # 46 hold #s #> type
 ;

 : millis.reset 		    
   0 ms_counter !		       \ reset the ms_counter to zero
 ;

 : millis.read			       \ read elapsed millis since millis.reset
   ms_counter @			       \ this will be updated by the systick-handler every systick
   pretty.print  ." ms " cr
 ;