# CSharpLearning
### 看教程入门C#  
* day0504  
  * 分别创建了console和wpf应用，并输出hello world  
  * 项目名字不能和系统本身命名空间重合，否则会出现无法引用的情况  
  * wpf应用使用xml来保存窗体结构，且xml有5个不同的xmlns
  * xml使用有助于实现设计重用和前后端分离
  * c#各类应用程序：console,wpf,asp.net mvc,cloud等
  * 不同的项目模板就是引用了不同所需要的类库
  * 引用
    * 黑盒引用：直接引用添加到引用库，但无法进行修改
    * 白盒引用：添加到项目，形成一个sln多个project的结构，可以进行修改
  * Class Library就是写dll类库的
*******************************************
* day0505
  * 装箱：把值类型转变成引用类型  
  ```int x=10;  Object obj=x;```
  * 拆箱：把引用类型转变成值类型  
  ```Object obj=10; int y=[int]obj;```
  * 调试的step into, step over, step out
  * 操作符的本质：函数（算法）的简记法
  * 属性
  * 各种参数：值，引用，输出，数组，具名，this
  * 委托
  * 事件的完整定义
*******************************************************
