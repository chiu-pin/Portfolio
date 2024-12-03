/* prog8_12,費氏數列 */
#include <stdio.h>
#include <stdlib.h>
int ff(int);
double fib(int);
int gcd(int,int);		
int main(void)
{
   int n;
   for(n=1;n<=10;n++)			
      printf("疊代ff(%d)=%d\n",n,ff(n));		
 	for(n=1;n<=10;n++)			
      printf("迴圈fib(%d)=%lf\n",n,fib(n));
    int x=20,y=25;
    printf("%d,%d迴圈輾轉相除%d\n",x,y,gcd(x,y));
   system("pause");
   return 0;
}

int ff(int n) 		
{	
   if(n==1||n==2)	
      return 1;
   else				
      return (ff(n-1)+ff(n-2));
}

double fib(int n) 		
{	
	double f1=1,f2=1;
	int i=3;
	double fn;
	if(n>2)
		for(;i<=n;i++){
			fn=f1+f2;
			f2=f1;
			f1=fn;
		}
	else
		fn=1.0;
	return fn;
}
int gcd(int a,int b){
	int r;
	while(b>0){
		r=a%b;
		a=b;
		b=r;
	}
	return a;
}
