#require f0-disco-48mhz.fs
#require f0-millis.fs
#require dump.fs
#require stack.fs
#require output.fs
#require bitfields.fs
#require free.fs

: init
    init
    f0-disco-48mhz
    free
    cr
;