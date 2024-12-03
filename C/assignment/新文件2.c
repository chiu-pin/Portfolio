/* prog8_6, 計算 x的n次方 */
#include <stdio.h>
#include <stdlib.h>
double power(double, int);
double Fx(double);
int main(void)
{
   int i=3;
   double sum;
   sum=0;
   double x;
   scanf("%f",&x);
   printf("結果為%f",Fx(x));
   system("pause");
   return 0;
}

double power(double base, int n)   
{
   int i;
   double pow=1.0;
   for(i=1;i<=n;i++)		
       pow*base;
   return pow;
}
double Fx(double base){
	double sum;
	sum=3*power(base,3)+2*power(base,2)+power(base,1)+14;
	return sum;
}
