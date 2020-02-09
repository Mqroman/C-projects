#include <iostream>
#include <fstream>
#include <cstring>
#include <ctime>
#include <cstdlib>
using namespace std;
ifstream cinn("animale.txt");
char c[9101][101],g[901],k[901],z[901],o[901];
int i=0,n,j,sum=2,ok=1,p=1,nrincercari=0,prim=1,oy=0;
void implementare()
{char a[901];
    while(cinn>>a)
   i++,strcpy(c[i],a);
}
int random()
{int o;
    srand(static_cast<unsigned int>(time(0)));
o=rand();while(o>=i)o=o/10;
if(strcmp(c[o],"cuvantfolosit")==0)random();
return o;
}
void ignorA(char &a)
{
     if(a>='A'&&a<='Z')
 a=a+32;
}
void scrie()
{
    int y ;cout<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<"                           ";
    for(y=0;y<n;y++)
    cout<<k[y]<<" ";cout<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<endl<<"Litere folosite: ";

    for(y=1;y<p;y++)
    cout<<z[y]<<" ";

    cout<<endl<<endl<<endl<<endl;
}
void crearecuvant()
{
    strcpy(g,c[j]);
 n=strlen(g);
 k[0]=g[0];k[n-1]=g[n-1];
 for(int y=1;y<n-1;y++)if(g[y]==g[0]||g[y]==g[n-1])k[y]=g[y],sum++;else k[y]='_';
}
void iflitera(char a)
{for(int y=1;y<n-1;y++){ignorA(a);if(g[y]==a&&k[y]=='_')k[y]=a,sum++;}

}
void verificare()
{
    if(sum==n)ok=0;
}
void info()
{
char w[101]="play",q[101],x[101];
    cout<<endl<<endl<<endl<<"Un joc simplu de ghicire a cuvantului prin folosiri repetate de litere."<<endl<<endl<<"Jocul contine aproximativ 3350 de cuvinte diferite.";
  cout<<endl<<endl<<endl<<endl<<"Pentru pornire scrieti PLAY !";
  cin>>q;if(stricmp(w,q)){
  while(stricmp(w,x))
 {if(strcmp(q,x))cout<<endl<<endl<<endl<<endl<<"Pentru pornire scrieti PLAY !",strcpy(q,x);cin>>x;}oy=1;}
 else oy=1;
 }

void mai()
{
char l,q[901];

if(prim)implementare(),info();
     j=random();
     crearecuvant();
     scrie();

 while(ok)
    {cout<<"Cauta litera : ";cin>>l;iflitera(l);verificare();
    z[p]=l;p++;scrie();nrincercari++;}
    if(ok==0)cout<<endl<<"        Felicitari ai descoperit cuvantul din "<<nrincercari<<" incercari."<<endl<<endl<<endl<<endl;

   cout<<"Pentru a continua scrieti CONTINUA !";
   cin>>q;if(stricmp(q,"continua")==0)sum=2,ok=1,p=1,nrincercari=0,strcpy(z,o),strcpy(k,o),strcpy(c[j],"cuvantfolosit"),prim=0,mai();
}
int main()
{
    mai();
    return 0;
}
