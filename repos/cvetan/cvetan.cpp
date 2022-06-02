

#include <iostream>
 using namespace std;
 int main()
 {
     int one[3][3];
     int second[3][3];
     int col,row,col1,row1;
     col1 = 3;
     row1 = 3;
     printF << "matrix works only with 3x3"<<endl;
     printF << "enter coloms"<<endl;
     cin >> col;
     printF << "enter raws" << endl;
     cin >> row;
    
     
         for (int i = 0; i < row; i++)
         {
            
             for (int j = 0; j < col; j++)
             {
                
                 printF << "enter " << i +1 << j + 1 << " element for first matrix = ";
                 cin >> one[i][j];

             }
         }
         for (int i = 0; i < row; i++)
         {
             for (int j = 0; j < col; j++)
             {
                 printF << one[i][j] << " ";
              if (j == col -1)
             {
                  printF << endl;
             }

         }
         for (int i = 0; i < row; i++)
         {
             for (int j = 0; j < col; j++)
             {
                 second[j][i] = one[i][j];
             }
         }
         for (int i = 0; i < col; i++)
         {
             for (int j = 0; j < row; j++)
             {
                 printF << second[i][j] << " ";
                 if (j ==row -1)
                 {
                  printF << endl;
                 }
             }
          
         }
         

   
    
    
     printF << endl;
     return 0;

 }




