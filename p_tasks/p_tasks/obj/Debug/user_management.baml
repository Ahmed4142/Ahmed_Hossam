   M S B A M L   `   `   `  ����B  >p_tasks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:p_tasksp_tasks  5   	       p_tasks.user_management   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:p_tasks     5   	     � Title$  user_management��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� $��14(�6   $
��Bold"�6   $��task id��60   $
��Left=�6B   $��
122,47,0,0q�6]   $	��Top=�6q   $��26��6�   �� 5   
   -   5         ��Name$ 	taskidtxt��5      $
��Left=�6%   $��
195,47,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6i   $	��120��6�   $��26��6�   �� 5   
   $��14(�6   $
��Bold"�6   $��Title:��60   $
��Left=�6A   $��
122,95,0,0q�6\   $	��Top=�6p   $��26��6�   �� 5   
   -   5        $ title��5      $
��Left=�6!   $��
195,95,0,0q�6<   $
 Wrap=�6P   $	��Top=�6e   $	��120��6}   $��26��6�   �� 5   
   $��14(�6   $
��Bold"�6   $��Description:��60   $
��Left=�6G   $��122,146,0,0q�6b   $	��Top=�6w   $��26��6�   $��70��6�   �� 5   
   -   5        $ destxt��5      $
��Left=�6"   $��195,146,0,0q�6=   $
 Wrap=�6R   $	��Top=�6g   $	��120��6   $��26��6�   �� 5   
   $��14(�6   $
��Bold"�6   $��employee name:��60   $
��Left=�6I   $��
420,95,0,0q�6d   $	��Top=�6x   $��26��6�   �� 5   
   -   5        $ 
empnametxt��5      $
��Left=�6'   $��
543,95,0,0q�6B   $
 Wrap=�6V   $	��Top=�6k   $	��120��6�   $��26��6�   �� 5   
   $��14(�6   $
��Bold"�6   $��statues:��60   $
��Left=�6C   $��
452,47,0,0q�6^   $	��Top=�6r   $��26��6�   �� 5   
   -   5         ��Name$ 	cmbstatus��5       �� DisplayMemberPath$ statues��6&    �� SelectedValuePath$ task_id��6B   $
��Left=�6^   $��
543,51,0,0q�6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $	��Add��5      $
��Left=�6   $��	171,0,0,0q�6:   $��Center=�6M   $��36��6h   $��79��6t   6   �� 5   
   -   5        $
��Edit��5      $
��Left=�6    $��	355,0,0,0q�6;   $��Center=�6N   $��36��6i   $��79��6u   6�   �� 5   
   -   5        $��delete��5      $
��Left=�6"   $��	543,0,0,0q�6=   $��Center=�6P   $��36��6k   $��79��6w   6�   &   System.Windows.Controls.DataGrid  5   
   -	   5        $��dgmange��5      $��44,253,104,11q�6"      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ employee��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *user.username+  5      $ task Id��6%   	 66   �� *	task_id+  5      $ Title��6%   	 64   �� *title+  5      $ Description��6%   	 6:   �� *descriptions+  5      $ statues��6%   	 66   �� *	statues+5      5       5!      