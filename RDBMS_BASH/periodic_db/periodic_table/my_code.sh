#! /bin/bash

PSQL="psql --username=freecodecamp --dbname=periodic_table -t --tuples-only -c"

if [[ -z $1 ]]
then
  echo -e "Please provide an element as an argument."
  exit
fi

#if argument is atomic number
if [[ $1 =~ ^[1-9]+$ ]]
then
  ELEMENT=$($PSQL "SELECT atomic_number, name, symbol, type, atomic_mass, melting_point_celsius, boiling_point_celsius FROM elements JOIN properties USING(atomic_number) JOIN types USING(type_id) WHERE atomic_number = '$1' ORDER BY atomic_number")
else
#if argument is string
  ELEMENT=$($PSQL "SELECT atomic_number, name, symbol, type, atomic_mass, melting_point_celsius, boiling_point_celsius FROM elements JOIN properties USING(atomic_number) JOIN types USING(type_id) WHERE name = '$1' OR symbol = '$1' ORDER BY atomic_number")
fi

#element not in db
if [[ -z $ELEMENT ]]
then
  echo -e "I could not find that element in the database."
  exit
fi

echo $ELEMENT | while read AT_N BAR NAME BAR SYMBOL BAR TYPE BAR MASS BAR MP BAR BP 
do
  echo "The element with atomic number $AT_N is $NAME ($SYMBOL). It's a $TYPE, with a mass of $MASS amu. Hydrogen has a melting point of $MP.1 celsius and a boiling point of $BP celsius."
done
