#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int i,j,N=10;
	for(i=1;i<=N-1;i++){
		printf("%2d",i);
		for(j=1;j<=N-i;j++)
			putch(' ');
		for(j=1;j<=i*2-1;j++){
			if(j==i)
				putch('*');
				else
				putch(' ');
			}
		for(j=1;j<=N-i;j++)
			putch(' ');
		printf("\n");
	}
	printf("%2d",N);
	for(i=1;i<=N*2-1;i++){
		putch('*');
	}
	printf("\n");
	for(i=N-1;i>=1;i--){
		printf("%2d",i);
		for(j=1;j<=N-i;j++)
			putch(' ');
		for(j=1;j<=i*2-1;j++){
			if(j==i)
				putch('*');
				else
				putch(' ');
			}
		for(j=1;j<=N-i;j++)
			putch(' ');
		printf("\n");
	}
				
	return 0;
}

