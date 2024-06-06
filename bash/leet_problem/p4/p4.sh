#!/bin/bash

# for i in $(seq 1 $(head -n 1 file.txt | wc -w));
# do
#     echo $(awk -v col=$i '{print $col}' file.txt)
# done

for i in $(seq 1 2);
do
    echo $(awk -v col=$i '{print $col}' file.txt)
done