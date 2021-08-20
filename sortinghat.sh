#!/bin/bash
#sorting hat program
echo "What is your name?"
read NAME

if [ "$NAME" = "Hermione" ]
then
        echo "Gryffindor!"

elif [ "$NAME" = "Luna" ]
then
        echo "Ravenclaw!"

else
        echo "You are a muggle."
fi
