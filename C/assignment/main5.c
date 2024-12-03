#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int a=54321;
	char c[5];
	int b=1,i=0;
	while(a>b){
	  b=b*10;
	  i=i+1;
	}
	ptintf("%d",i);
	
	
	c[5]='\0';
	
	c[4]=a-a/10*10+'0';
	a=a/10;
	
	c[3]=a-a/10*10+'0';
	a=a/10;
	
	c[2]=a-a/10*10+'0';
	a=a/10;
	
	c[1]=a-a/10*10+'0';
	a=a/10;
	c[0]=a-a/10*10+'0';
	a=a/10;
	
	printf("%s",c);
	return 0;
}
