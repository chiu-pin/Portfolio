#include <stdio.h>
#include <stdlib.h>
double power(double, int);
double Fx(double);
double fff(double);
double FFF(double,double);
int main(void)
{
   double sum;
   sum=0;
   double x;
   x=5;
   double i;
   for(;i<=5.0;i++){
   		printf("%f代入結果為%f\n",i,Fx(i)); 	
   }
   i=0;
   for(;i<=5.0;i++){
   		printf("%f代入微分結果為%f\n",i,fff(i)); 	
   }
   printf("1,2代入積分結果為%f\n",FFF(1,2)); 	
   
   	
   system("pause");
   return 0;
}
double power(double base, int n)   
{
   int i;
   double pow=1.0;
   for(i=1;i<=n;i++)		
      pow=pow*base;
   return pow;
}
double Fx(double base){
	double sum;
	sum=3*power(base,3)+2*power(base,2)+power(base,1)+14;
	return sum;
}
double fff(double base){
	double dx;
	dx=10e-6;
	double sum;
	sum=(Fx(base+dx)-Fx(base))/dx;
	return sum;
}
double FFF(double x1,double x2){
	double dx,xx;
	dx=10e-6;
	double sum=0;
	for(xx=x1;xx<=x2;xx+=dx){
		sum+=Fx(xx)*dx;
	}
	return sum;
}


