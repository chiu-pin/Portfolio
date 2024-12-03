/* prog7_5, 無窮迴圈的應用 */
#include <stdio.h>
#include <stdlib.h>
int main(void)
{
   char ch;
   while(ch!=13)		
   {
       ch=getch();			
       printf("ASCII of ch=%d\n",ch);	
   }
   printf("您已按了enter...\n");
   
   system("pause");
   return 0;
}


