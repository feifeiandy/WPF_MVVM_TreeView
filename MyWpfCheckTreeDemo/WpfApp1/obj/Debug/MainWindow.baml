   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      B >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1 5      !clr-namespace:WpfApp1WpfApp1 5	      p lTelerik.Windows.Controls.Navigation, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7pSclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.NavigationTelerik.Windows.Controls 5
         WpfApp1.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9System&clr-namespace:System;assembly=mscorlib     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      (myTypeclr-namespace:WpfApp1     5	      gtelerikSclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Navigation     5
      f bTelerik.Windows.Documents, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a	 ]Telerik.Windows.Data, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p
 lTelerik.Windows.Controls.RibbonView, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Documents.Core, Version=2015.1.401.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Rtelerik11http://schemas.telerik.com/2008/xaml/presentation
   	 
       5      -   5          � Title$  
MainWindow��5      $	��800��5      $	��450��5       � 	Resources 5         MyTreeItemTemplate �� DataType  WpfApp1.Student �� ItemsSource �� Mode �� Orientation  WpfApp1.StstusConvert  con.  (Telerik.Windows.Controls.RadTreeViewItem �� 
TargetType �� Property  TreeViewItemDefaultTemplate �� Value	 �� 	Converter��%  &	        &	 �     '  �     7  7  �� 5   
   "  5       5      �� *Stus+$ OneWay=�.R�5      �� $ 
Horizontal=�6   .+�5      �� ��6   �� *Name+5      5        5   
   6   �� 5   
   "  6   .�5      ��  � ��8   6)   �� 5       � ��$ 15(�6)   �� 5       �@ 
IsExpanded . 6+   �� 5       �@ 
IsSelected 6+   �� *
IsSelect+$ TwoWay=��� 5        �@ 
CheckState 6+   �� *	IsChecked+8	  $ TwoWay=�5!      5"      .��5#      (� 
 (� Stretch$
 Uniform=�6   .��5$   
   � $	��800��6   .+�5%      *  $Telerik.Windows.Controls.RadTreeView  $��0,0,10,117.293q�5&      $��30(�5'         IsOptionElementsEnabled .    IsTriStateMode . #��[  5*        RadTreeViewStyle#��[ 5-      ��5+      �� *
Students+   SelectedItem 5,      �� *SelectStudent+5-      �� 5.      $��75��5/      $��294,351,0,0q�50      $
��Left=�51      $	��Top=�52      $��Button��54      ��53      �� *
btnCommand+54      55      56      57      