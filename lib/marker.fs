  : marker ( name -- )
  <builds begin here $3FF and while 0 h, repeat
  does>   begin dup  $3FF and while 2+   repeat
  eraseflashfrom ;