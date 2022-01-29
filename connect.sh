#!/bin/bash

# Run 'sudo usermod -a -G dialout $USER' to grant rights to open the serial port

e4thcom -t mecrisp-st -d ttyS0 -b B115200 | tee /var/log/e4thcom.log