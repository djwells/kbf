: free
    compiletoram? if
        unused
        compiletoflash
        unused
        compiletoram
    else
        unused
        compiletoram
        unused swap
        compiletoflash
    then
    ." Flash: " .
    cr ."   RAM: " .
;