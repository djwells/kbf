1024 variable maxdepth-.s

: d.r
  >r tuck dabs <# #s rot sign #> r> over - spaces type ;

: .r   >r s>d r> d.r ;

: .s
 ." <" depth 0 .r ." > " depth 0 max maxdepth-.s @ min dup 0
  ?DO    dup i - pick .
  LOOP
  drop ;