echo hello bash
echo hello bash > stdout.txt
echo hello bash >> stdout.txt
echo hello bash > stdout.txt
echo > stdout.txt
> stdout.txt
< stdout.txt
> stdout
rm stdout
clear
ecpo > stdout.txt
bad_command
bad_command > stdout.txt
bad_command > stderr.txt
bad_command 2> stderr.txt
echo hello bash 1> stdout.txt
read NAME
echo $NAME
echo $NAME > stdout.txt
echo freeCodeCamp > name.txt
echo $NAME < name.txt
read $NAME < name.txt
read NAME < name.txt
echo $NAME
clear
echo chandan | read NAME
echo chandan | read NAME | echo $NAME
cat 
cat name.txt
cat < name.txt
echo chandan | cat
touch script.sh
chmod +x ./scripts.sh
chmod +x ./script.sh
clear
./ script.sh
clear
./script.sh
./script.sh | Chandan Kumar
clear
./script.sh
clear
echo chandan | ./script.sh
echo chandan | ./script.sh | echo 2> stderr.txt
echo chandan | ./script.sh 2> stderr.txt
echo chandan | ./script.sh 1> stdout.txt 2>stderr.txt
cat name.txt | ./script.sh 1> stdout.txt 2>stderr.txt
cat name.txt | ./script.sh
./script.sh < name.txt
./script.sh < name.txt 2> stderr.txt
./script.sh < name.txt 1> stdout.txt2> stderr.txt
./script.sh < name.txt 1> stdout.txt 2> stderr.txt
cat kitty_ipsum_1.txt
cat kitty_ipsum_2.txt
clear
wc help
wc --help
clea
clear
wc kitty_ipsum_1.txt
man wc
wc -l kitty_ipsum_1.txt
man wc
wc -w kitty_ipsum_1.txt
wc -c kitty_ipsum_1.txt
man wc
wc -m kitty_ipsum_1.txt
wc kitty_ipsum_1.txt
cat kitty_ipsum_1.txt | wc
wc <  kitty_ipsum_1.txt
echo ~~ kitty_ipsum_1.txt.info ~~ > kitty_info.txt
echo "~~ kitty_ipsum_1.txt.info ~~" > kitty_info.txt
echo '~~ kitty_ipsum_1.txt.info ~~' > kitty_info.txt
echo ~~ 'kitty_ipsum_1.txt.info' ~~ > kitty_info.txt
echo "~~ kitty_ipsum_1.txt info ~~" > kitty_info.txt
clear
echo -e "\nNUMBER of Lines:" >> kitty_info.txt
echo -e "\nNumber of Lines:" >> kitty_info.txt
echo -e "\nNumber of lines:" >> kitty_info.txt
cat kitty_ipsum_1.txt | wc -l
cat kitty_ipsum_1.txt | wc -l >> kitty_info.txt
echo -e "\nNumber of words:" >> kitty_info.txt
cat kitty_ipsum_1.txt | wc w
man wc
cat kitty_ipsum_1.txt | wc -w
cat kitty_ipsum_1.txt | wc -w >> kitty_info.txt
echo -e "\nNumber of characters:" >> kitty_info.txt
cat kitty_ipsum_1.txt | wc -m
man wc
cat kitty_ipsum_1.txt | wc -m >> kitty_info.txt
cat kitty_ipsum_1.txt | wc -c >> kitty_info.txt
wc -m < kitty_ipsum_1.txt >> kitty_info.txt
grep 'meow' kitty_ipsum_1.txt
man grap
man grep
grep -c 'meow' kitty_ipsum_1.txt
grep -color 'meow' kitty_ipsum_1.txt
grep --color 'meow' kitty_ipsum_1.txt
grep -l 'meow' kitty_ipsum_1.txt
grep -L 'meow' kitty_ipsum_1.txt
clear
man grep
grep -m NUM 'meow' kitty_ipsum_1.txt
man grep
grep -n 'meow' kitty_ipsum_1.txt
men grep
man grep
grep -n kitty_ipsum_1.txt
grep --color -n 'meow' kitty_ipsum_1.txt
grep --color -n 'meow[a-z]*' kitty_ipsum_1.txt
echo -e "\nNumber of times meow or meowzer appears:" >> kitty_info.txt
grep --color -n 'meow[a-z]*' kitty_ipsum_1.txt
man grep
grep --color -n -c 'meow[a-z]*' kitty_ipsum_1.txt
grep --color -c -n 'meow[a-z]*' kitty_ipsum_1.txt
man grep
grep --color 'meow[a-z]*' kitty_ipsum_1.txt
grep -c 'meow[a-z]*' kitty_ipsum_1.txt
man grep
grep -f 'meow[a-z]*' kitty_ipsum_1.txt
grep 'meow[a-z]*' -f kitty_ipsum_1.txt
man grep
grep -o 'meow[a-z]*' kitty_ipsum_1.txt
grep -o 'meow[a-z]*' kitty_ipsum_1.txt | wc -l
grep -o 'meow[a-z]*' kitty_ipsum_1.txt | wc -l >> kitty_info.txt
echo -e "\nLines that they appear on:" >> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_1.txt
man grep
man grep
cat name.txt
sed 's/%r%/2/' name.txt
sed 's/r/2/' name.txt
sed 's/free/f233/' name.txt
sed 's/freecodecamp/f233C0d3C@mp/' name.txt
sed 's/freecodecamp/f233C0d3C@mp/i' name.txt
sed 's/freecodecamp/f233C0d3C@mp/i' < name.txt
cat name.txt | sed 's/freecodecamp/f233C0d3C@mp/i'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed '/s/[0-9]/1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed '/s/[0-9]*/1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed '/s/0-9/1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed 's/[0-9/]1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed 's/[0-9/]/1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed 's/[0-9]/1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed 's/[0-9]+/1/'
man sed
man sed
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed 's/+[0-9]+/1/'
man sed
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed -r 's/[0-9]+/1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed -r 's/([0-9]+)/\1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed -r 's/([0-9]+)/\1/'.*
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed -r 's/([0-9]+)/\1/.*'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed.* -r 's/([0-9]+)/\1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed -r 's/([0-9]+).*/\1/'
grep -n 'meow[a-z]*' kitty_ipsum_1.txt | sed -r 's/([0-9]+).*/\1/' >> kitty_info.txt
grep --color 'cat[a-z]*' kitty_ipsum_1.txt
echo -e "\nNumber of times cat, cats, or catnip appears:" >> kitty_info.txt
grep -o 'cat[a-z]*' kitty_ipsum_1.txt
grep -o 'cat[a-z]*' kitty_ipsum_1.txt | wc -l
grep -o 'cat[a-z]*' kitty_ipsum_1.txt | wc -l >> kitty_info.txt
echo -e "\nLines that they appear on:" >> kitty_info.txt
grep -n 'cat[a-z]*' kitty_ipsum_1.txt
grep -n 'cat[a-z]*' kitty_ipsum_1.txt | sed -r 's/([0-9]+).*/\1/'
grep -n 'cat[a-z]*' kitty_ipsum_1.txt | sed -r 's/([0-9]+).*/\1/' >> kitty_info.txt
clear
echo -e "\n\n~~ kitty_ipsum_2.txt info ~~" >> kitty_info.txt
echo -e "\nNumber of lines" >> kitty_info.txt
echo -e "\nNumber of lines:" >> kitty_info.txt
cat kitty_ipsum_2.txt | wc -l
cat kitty_ipsum_2.txt | wc -l >> kitty_info.txt
echo -e "\nNumber of words:" >> kitty_info.txt
man wc
 wc -w < kitty_ipsum_2.txt >> kitty_info.txt
echo -e "\nNumber of characters:" >> kitty_info.txt
 wc -m < kitty_ipsum_2.txt >> kitty_info.txt
grep -n --color 'meow[a-z]*' kitty_ipsum_2.txt
grep --color 'meow[a-z]*' kitty_ipsum_2.txt
echo -e "\nNumber of times meow or meowzer appears" >> kitty_info.txt
echo -e "\nNumber of times meow or meowzer appears:" >> kitty_info.txt
grep --color 'meow[a-z]*' kitty_ipsum_2.txt | wc -l
grep --color 'meow[a-z]*' kitty_ipsum_2.txt | wc -l >> kitty_info.txt
grep-or 'meow[a-z]*' kitty_ipsum_2.txt | wc -l >> kitty_info.txt
grep -o 'meow[a-z]*' kitty_ipsum_2.txt | wc -l >> kitty_info.txt
echo -e "\nLines that they appear on:" >> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed 's/([0-9)+).*/\1/'>> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9)+).*/\1/'>> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9)+).*/\1/' >> kitty_info.txt
man sed
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9)+).*/\1/' kitty_ipsum_2.txt >> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9)+).*/\1/' >> kitty_info.txt
man sed
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -E 's/([0-9)+).*/\1/' >> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9)+).*/\1/' >> kitty_info.txt
clear
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9)+).*/\1/' >> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9])+).*/\1/' >> kitty_info.txt
grep -n 'meow[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9]+).*/\1/' >> kitty_info.txt
grep -n 'cat[a-z]*' kitty_ipsum_2.txt
grep --color 'cat[a-z]*' kitty_ipsum_2.txt
echo -e "\nNumber of times cat, cats, or catnip appears:" >> kitty_info.txt
grep --color 'cat[a-z]*' kitty_ipsum_2.txt | wc -l >> kitty_info.txt
grep -o 'cat[a-z]*' kitty_ipsum_2.txt | wc -l >> kitty_info.txt
echo -e "\nLines that they appear on:" >> kitty_info.txt
grep -n 'cat[a-z]*' kitty_ipsum_2.txt | sed -r 's/([0-9]+).*/\1/' >> kitty_info.txt
clear
touch translate.sh
chmod +x ./translate.sh
./translate.sh kitty_ipsum_1.txt
./translate.sh < kitty_ipsum_1.txt
cat kitty_ipsum_1.txt | ./translate.sh
clear
cat kitty_ipsum_1.txt | ./translate.sh
./translate.sh kitty_ipsum_1.txt
clear
./translate.sh kitty_ipsum_1.txt
./translate.sh kitty_ipsum_1.txt
./translate.sh kitty_ipsum_1.txt
./translate.sh kitty_ipsum_1.txt | grep --color 'dogchow'
./translate.sh kitty_ipsum_1.txt | grep --color 'catnip'
./translate.sh kitty_ipsum_1.txt | grep --color 'dog[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep --color 'cat[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep --color 'cat[a-z]*|woof'
./translate.sh kitty_ipsum_1.txt | grep --color 'dog[a-z]*|woof'
./translate.sh kitty_ipsum_1.txt | grep --color 'dog[a-z]* | woof'
./translate.sh kitty_ipsum_1.txt | grep --color 'dog[a-z]* | woof[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep --color 'dog[a-z]*|woof[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep -r --color 'dog[a-z]*|woof[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep -r --color 'dog[a-z]*|woof[a-z]*'
man grep
./translate.sh kitty_ipsum_1.txt | grep -E --color 'dog[a-z]*|woof[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep -E --color 'dog[a-z]*|woof[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep -E --color 'dog[a-z]*|woof[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep -E --color 'cat[a-z]*|meow[a-z]*'
./translate.sh kitty_ipsum_2.txt | grep -E --color 'cat[a-z]*|meow[a-z]*'
./translate.sh kitty_ipsum_1.txt | grep -E --color 'cat[a-z]*|meow[a-z]*' >> doggy_ipsum_1.txt
./translate.sh kitty_ipsum_1.txt > doggy_ipsum_1.txt
cat doggy_ipsum_1.txt
diff kitty_ipsum_1 doggy_ipsum_1
diff kitty_ipsum_1.txt doggy_ipsum_1.txt
man diff
diff -y kitty_ipsum_1.txt doggy_ipsum_1.txt
man diff
diff --color kitty_ipsum_1.txt doggy_ipsum_1.txt
diff --color -y  kitty_ipsum_1.txt doggy_ipsum_1.txt
diff -y --color  kitty_ipsum_1.txt doggy_ipsum_1.txt
clear
./translate.sh kitty_ipsum_2.txt > doggy_ipsum_2.txt
cat doggy_ipsum_2.txt
diff --color  kitty_ipsum_2.txt doggy_ipsum_2.txt
