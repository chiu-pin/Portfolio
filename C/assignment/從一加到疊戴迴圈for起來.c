/* prog8_12,¶O¤ó¼Æ¦C */
#include <stdio.h>
#include <stdlib.h>
int ff(int);int fib(int);			
int main(void)
{
   int n;
   for(n=1;n<=10;n++)			
      printf("ff(%d)=%d\n",n,ff(n));		
 	for(n=1;n<=10;n++)			
      printf("fib(%d)=%d\n",n,fib(n));
   system("pause");
   return 0;
}

int ff(int n) 		
{	
   if(n==1||==2)	
      return 1;
   else				
      return (ff(n-1)+ff(n-2));
}

int fib(int n) 		
{	
	int a=1,b=1;
	int i=3;
	int sum;
	for(;i<=n;i++){
		sum=a+b;
		a=b;
		b=sum;
	}
	return sum;
}




