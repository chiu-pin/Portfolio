#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	//unsigned short x=32767;
	//short y=32768;
    //printf("%d",x+y);	
	int i=0,k=1;
	char ch[10];
	printf("½Ð¿é¤J¼Æ¦r\n");
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
	printf("%s",ch);
	return 0;
}
