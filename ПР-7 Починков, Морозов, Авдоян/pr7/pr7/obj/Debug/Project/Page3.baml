   M S B A M L   `   `   `  ����>  :pr7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:pr7.Projectpr7.Project  5          pr7.Project.Page3   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:pr7.Project     5        N� Title$  Page3��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��89* �6   �� 5      $
��311* �6    � RowDefinitions 5   
   �� 5      $
��377* �6   �� 5      $��5* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGridpage3��5      $��236,16,28,22q�6(      AutoGenerateColumns .  $��1��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ IP-адрес��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Names+  5      $ Кабинет��6%   $ * 66    6@   �� *	Version+  5      $" Характеристика��6%   $ * 6=    6G   �� *Class+5      �� 5   
   $��IP-адрес��6   $
��Left=�6#   $��136,113,0,0q�6>   $	��Top=�6S   $��32��6k   $��84��6w   $��18(�6�   $��Britannic Bold)�6�   ���#333333$��2��6�   �� 5   
   -   5        	 ��Name$	 txbip��5      $
��Left=�6!   $��
49,115,0,0q�6<   
 �� TextWrapping$

 Wrap=�6P   $��Britannic Bold)�6d   $	��Top=�6�   $	��167��6�   $��24��6�   ���#333333$��1��6�   �� 5   
   $��Кабинет��6   $
��Left=�6"   $��132,154,0,0q�6=   $	��Top=�6R   $��30��6j   $��89��6v   $��18(�6�   $��Britannic Bold)�6�   ���#333333$��2��6�   �� 5    
   -   5        $	 	txboffice��5       $
��Left=�6%   $��
49,156,0,0q�6@   $

 Wrap=�6T   $��Britannic Bold)�6h   $	��Top=�6�   $	��167��6�   $��24��6�   ���#333333$��1��6�   �� 5!   
   $"��Характеристика��6   $
��Left=�6)   $��
75,194,0,0q�6D   $	��Top=�6X   $��30��6p   $	��151��6|   $��18(�6�   $��Britannic Bold)�6�   ���#333333$��2��6�   �� 5"   
   -   5        $	 txbCharacteristic��5"      $
��Left=�6-   $��
49,197,0,0q�6H   $

 Wrap=�6\   $��Britannic Bold)�6p   $	��Top=�6�   $	��167��6�   $��24��6�   ���#333333$��1��6�   �� 5#   
   -   5        $	��Add��5#   $   $��Добавить��6   $
��Left=�6/   $��
48,272,0,0q�6J   $	��Top=�6^   $��37��6v   $	��333��6�   ���#333333���#ffffff$��2��6�   ��5$      �� 5%       �� 
TargetType" ��6   .�5&      ��  �� Property � �� �� Value 5'      �� 5(       �� 
TargetType" ��6.   .R�5)   "   ��  �� CornerRadius$ 9��6)   ���#000000$��1q�6P   #��z��5*      ._�5,   &   �� #��z��67   #��z��5-   '   5.   #   5/      51      52      54      �� 55   
   -   5        $��Delete��55   #   $��Удалить��6   $
��Left=�61   $��
48,314,0,0q�6L   $	��Top=�6`   $��37��6x   $	��333��6�   ���#333333���#ffffff$��2��6�   ��56      �� 57      " ��6   .�58      ��  � �� 59      �� 5:      " ��6.   .R�5;   "   �� $ 9��6)   ���#000000$��1q�6P   #��z��5<      ._�5>   &   �� #��z��67   #��z��5?   '   5@   #   5A      5C      5D      5F      �� 5G   
   -   5        $
��Back��5G   !   $��
Назад��6   $
��Left=�6-   $��
52,358,0,0q�6H   $	��Top=�6\   $��37��6t   $	��333��6�   ���#333333���#ffffff$��2��6�   ��5H      �� 5I      " ��6   .�5J      ��  � �� 5K      �� 5L      " ��6.   .R�5M   "   �� $ 9��6)   ���#000000$��1q�6P   #��z��5N      ._�5P   &   �� #��z��67   #��z��5Q   '   5R   #   5S      5U      5V      5X      5Y      5Z      