#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int i=0,k=1;
	char ch[10];
	printf("叫块计\n");
	int ac;
	scanf("%d",&ac);
	while(ac>=k){
		i++;
		k=k*16;
	}
	ch[i]="\0";
	i--;
	int m;
	while(i>=0){
		m=ac&15;
		if(m>=10){
			ch[i]=m+'A'-10;}
		if(m<10){
			ch[i]=m+'0';}
		ac=ac>>4;
		i--;
	}
	printf("%s\n",ch);
	
	int a;
	scanf(" %d",&a);
	if(a&1)
		printf("琌计");
	if(!(a&1))
		printf("琌案计");	
	    
	return 0;
}
