/* prog8_12,¶O¤ó¼Æ¦C */
#include <stdio.h>
#include <stdlib.h>
int ff(int);			
int main(void)
{
   int n;
   for(n=1;n<=10;n++)			
      printf("ff(%d)=%d\n",n,ff(n));		

   system("pause");
   return 0;
}

int ff(int n) 		
{	
   if(n==0)	
      return 0;
   else				
      return n+ff(n-1);
}



