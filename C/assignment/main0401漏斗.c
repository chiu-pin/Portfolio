#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int x,y,N=5;
	for(y=N;y>=-N;y--)
		{
		printf("%2d",y);
		for(x=-N;x<=N;x++)
			if(x==-y)
				putch('\\');
			else if(x==0)
				putch('|');
				else if(x==y)
				 putch('/');
					 else if(y==0)
				 		putch('-');
						 else if(x<-y) 
						 	putch('*');
							 	else
							 	putch(' ');		
		putch('\n');
		}
	
	return 0;
}
