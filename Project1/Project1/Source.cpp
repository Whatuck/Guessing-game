#include <stdlib.h>;
#include <time.h>;
#include <stdio.h>;
#include <iostream>;
using namespace ::std;

int main()
{
	system("chcp 1251");
	int M[20] = {};
	int min = 999, k = 0, q, i = 0;
	int max = 0;
	srand(time(NULL));
	for (i = 0; i < 20; i++)
	{
		M[i] = rand();
		cout << M[i] << endl;

	}
	for (i = 0; i < 20; i++)
	{
		if (M[i] > max)
			max = M[i];
		cout << "max:/n" << max << endl;
	}
	return 0;
};
