// mazeDemo.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
using namespace std;

#include <iostream>
#include <iostream>
#include <string>
#include <cstring>
#include <cctype>
#include <cstdlib>
#include <ctime>

int main()
{
	// Board Array Creation
	char boardArray[2][4];

	// Number variables for later use
	int num1 = 0;
	int num2 = 0;

	// Get the number of rows and collumns present in the 2D array
	int arrayRows = sizeof(boardArray) / sizeof(boardArray[0]);
	int arrayCollumns = sizeof(boardArray) / sizeof(boardArray[1]);

	// Print the array
	for (int i = 0; i < arrayRows; i++)
	{
		for (int j = 0; j < arrayCollumns; j++)
		{
			if (j == 4)
			{
				cout << boardArray[i][j] << endl;
			}
			else
			{
				cout << boardArray[i][j];
			}
		}
	}

	string response = "";

	while (response != "quit")
	{
		getline(cin, response);

		if (response == "Up")
		{
			num1--;
		}
		else if(response == "Down")
		{
			num1++;
		}

		boardArray[num1][num2] = 'x';

		for (int i = 0; i < arrayRows; i++)
		{
			for (int j = 0; j < arrayCollumns; j++)
			{
				if (j == 4)
				{
					cout << boardArray[i][j] << endl;
				}
				else
				{
					cout << boardArray[i][j];
				}
			}
		}
	}
}


void FillBoard(int arrayRows, int arrayCollumns, char boardArray[][])
{
	// Fill the array with '-'
	for (int i = 0; i < arrayRows; i++)
	{
		for (int j = 0; j < arrayCollumns; j++)
		{
			boardArray[i][j] = '-';
		}
	}
}
