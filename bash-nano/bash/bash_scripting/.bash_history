echo hello bash
touch questionnaire.sh
ls
echo hello questionnaire > questionnaire.sh
echo hello questionnaire
sh questionnaire.sh
bash questionnaire.sh
which bash
which sh
./questionnaire.sh
ls -l
chmod +x questionnaire.sh
ls -l
./questionnaire.sh
./questionnaire.sh
clear
./questionnaire.sh
./questionnaire.sh
./questionnaire.sh
clear
./questionnaire.sh
./questionnaire.sh
./questionnaire.sh
./questionnaire.sh
clear
./questionnaire.sh
./questionnaire.sh
./questionnaire.sh
echo --help
man echo
./questionnaire.sh
./questionnaire.sh
man echo
man echo
./questionnaire.sh
./questionnaire.sh
./questionnaire.sh
./questionnaire.sh
clear
./questionnaire.sh
./questionnaire.sh
clear
./questionnaire.sh
clear
touch countdown.sh
chmod +x countdown.sh
./countdown.sh
./countdown.sh arg1 arg2 arg3
./countdown.sh arg1 arg2 arg3
help
clear
help
clear
man if
help if
./countdown.sh arg1
./countdown.sh arg2
./countdown.sh arg2
./countdown.sh 5
./countdown.sh 4
./countdown.sh 5
help if
help
help [[ expression ]]
help built-in
help builtin
help test
./countdown.sh 5
[[ 4 -le 5 ]]
echo $?
[[ 4 -ge 5 ]]
echo $?
[[ 4 -ge 5 ]]; echo $?
[[ 10 -ne 5 ]]; echo $?
bad_command; echo $?
ls; echo $?
ls -y; echo $?
help test
[[ -a countdown.sh ]]; echo $?
[[ -a bad_file.txt ]]; echo $?
[[ -x bad_file.txt ]]; echo $?
[[ -x countdown.sh ]]; echo $?
help [[
[[ -x countdown.sh && 5 -le 4 ]]; echo $?
[[ -x countdown.sh or 5 -le 4 ]]; echo $?
[[ -x countdown.sh || 5 -le 4 ]]; echo $?
clear
./countdown.sh 1
./countdown.sh -1
help
./countdown.sh 10
help
ls /
ls /bin
man sleep
sleep 3
./countdown.sh 3
clearclear
clear
./countdown.sh 3
./countdown.sh 3
clear
./countdown.sh 3
./countdown.sh 3
./countdown.sh 3
./countdown.sh 3
./countdown.sh 1
clear
help while
./countdown.sh 2
./countdown.sh 2
./countdown.sh 2
./countdown.sh 2
./countdown.sh 5
clear
touch bingo.sh
chmod +x ./bingo.sh
./bingo.sh
printenv
echo LANG
where LANG
which LANG
clear
printenv
echo $LANG
echo $-p
echo $declare -p
declare -p
echo $RANDOM
clear
./bingo.sh
./bingo.sh
./bingo.sh
./bingo.sh
I=0
echo $I
((I++))
echo $I
help let
((I += 10); echo $I; ;
((I += 10); ); echo $I
((I += 10))
echo $I
$((I += 10))
$((I + 10))
$(( I + 10 ))
$(( I + 4 ))
echo $((I+4))
echo $I
J=$((I-6))
echp $J
echo $J
echo $((J*5+25))
echo $J
declare -p
declare -p J
declare -p RANDOM
clear
./bingo.sh
echo $((RANDOM % 75))
echo $((RANDOM % 75 + 1))
./bingo.sh
./bingo.sh
./bingo.sh
help let
clear
./bingo.sh
./bingo.sh
./bingo.sh
./bingo.sh
./bingo.sh
./bingo.sh
clear
touch fortune.sh
chmod +x ./fortune.sh
./fortune.sh
ARR=("a" "b" "c")
echo ${ARR[1]}
echo $@
echo $@ARR
echo ${ARR[0]}
echo ${ARR[@]}
echo ${ARR[*]}
declare -pARR
declare -p ARR
./fortune.sh
help
help function
clear
./fortune.sh
./fortune.sh
./fortune.sh
./fortune.sh
./fortune.sh
help
help until
clear
help [[
./fortune.sh
help [[ expression ]]
[[ hello==hello ]]; echo $?
[[ hello == hello ]]; echo $?
[[ hello == world ]]; echo $?
[[ hello =~ world ]]; echo $?
[[ hello =~ el ]]; echo $?
[[ hello world =~ el wor ]]; echo $?
[[ "hello world" =~ "el wor" ]]; echo $?
[[ "hello world" =~ "lo wor" ]]; echo $?
[[ "hello world" =~ ^h ]]; echo $?
[[ "hello world" =~ ^h.+d$ ]]; echo $?
VAR="hello world"
echo $VAR
[[ $VAR == "hello world ]]; echo $?
[[ $VAR == "hello world" ]]; echo $?
;

"
[[ $VAR == "hello world" ]]; echo $?
[[ $VAR == \?$ ]]; echo $?
VAR="hello world?"
[[ $VAR == \?$ ]]; echo $?
[[ $VAR =~ \?$ ]]; echo $?
VAR="test?"
[[ $VAR =~ \?$ ]]; echo $?
[[ "test?" =~ \?$ ]]; echo $?
clear
./fortune.sh
./fortune.sh
./fortune.sh
clear
touch five.sh
chmod +x ./five.sh
./five.sh
./five.sh
clear
./five.sh
help
help type
type echo
type read
type if
typr then
type then
type bash
type psql
type ./five.sh
exit
