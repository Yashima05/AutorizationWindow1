   M S B A M L   `   `   `  ����K  GLoginPasswordApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LoginPasswordAppLoginPasswordApp  5           LoginPasswordApp.ListPres1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:LoginPasswordApp     5        N� Title$  	ListPres1��5	      .��5      �� 
�������._�5   
   �  � RowDefinitions 5      �� 5      $	��40* �6    �� 5      $
��282* �6    �� 5      $	��73* �6    .+�5      �� $��Resources/dup41QMfohY.jpg��6   $��10,0,720.6,2.4q�67   �� 5      $#��Список клиентов��6   $��25(�6/   $��Center=�6=   $	��Top=�6Z    �� TextAlignment$ Center=�6r   $	��200��6�   $��40��6�   $��283,2,310.6,0q�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ Dgrid��5      $��1��6&      AutoGenerateColumns .     
IsReadOnly . $��
0,0,-0.4,0q�6a   $��3��6u   
����ح�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Клиента��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6[   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *	client_id+6h     5      $ Фамилия��6)   $ * 6W   	 6:   �� *
lastname+6c     5      $ Имя��6)   $ * 6R   	 66   �� *	forname+6^     5      $ Отчество��6)   $ * 6Z   	 6;   �� *
fathername+6f   4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5   "   �� -   5        $ ��Редактировать��5   )   $
��auto��6A   $
��auto��6N   
�������6�   5      5!      5#      �� 5$      -   5        $��Добавить��5$      
������$
��auto��6@   $��40,14.8,603.6,14q�6M   $��2��6g   6t   �� 5%      -   5        $��Удалить��5%      
�������$��213,14.8,430.6,14q�6>   $
��auto��6Y   $��2��6f   6s   �� 5&      $��
Выйти��6   
�������$��597,14.8,46.6,14q�6<   $
��auto��6V   $��2��6c    � 5'      -   5        $��FrameAdd��5'   !   $��1��6   63   5(      5)      5*      