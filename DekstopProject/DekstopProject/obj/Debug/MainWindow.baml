   M S B A M L   `   `   `  ����I  EDekstopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DekstopProjectDekstopProject  5   	       DekstopProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DekstopProject     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5
      $
��Left=�6%   $	��287��6@   $��	10,10,0,0q�6M   $	��Top=�6`   $	��423��6x   �� 5   
   -   5         ��Name$ btnGet��5      $	��GET��6!   $
��Left=�6/   $��
10,302,0,0q�6J   $	��Top=�6^   $	��423��6v   6�   �� 5   
   -   5         ��Name$ txtGet��5      $
��Left=�6"   $��23��6=   $��
438,10,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $��id��6q   $	��Top=�6{   $	��331��6�   �� 5   
   -   5        $ btnGetWithId��5      $��GET/{id}��6'   $
��Left=�6:   $��
438,38,0,0q�6U   $	��Top=�6i   $	��331��6�   6�   �� 5   
   -   5        $ txtPost��5      $
��Left=�6#   $��23��6>   $��
438,93,0,0q�6J   $
 Wrap=�6^   $
��name��6r   $	��Top=�6~   $	��331��6�   �� 5   
   -   5        $ btnPost��5      $��POST{[FromBody Thing]}��6"   $
��Left=�6C   $��438,121,0,0q�6^   $	��Top=�6s   $	��331��6�   6�   �� 5   
   -   5        $ 
txtNamePut��5      $
��Left=�6&   $��23��6A   $��438,192,0,0q�6M   $
 Wrap=�6b   $
��name��6v   $	��Top=�6�   $	��331��6�   �� 5   
   -   5        $ btnPut��5      $#��PUT{int id, [FromBody] Thing}��6!   $
��Left=�6I   $��438,220,0,0q�6d   $	��Top=�6y   $	��331��6�   6�   �� 5   
   -	   5        $ txtIdPut��5      $
��Left=�6$   $��23��6?   $��438,164,0,0q�6K   $
 Wrap=�6`   $��id��6t   $	��Top=�6~   $	��331��6�   �� 5   
   -
   5        $ txtIdDelete��5      $
��Left=�6'   $��23��6B   $��438,274,0,0q�6N   $
 Wrap=�6c   $��id��6w   $	��Top=�6�   $	��331��6�   �� 5   
   -   5        $ 	btnDelete��5      $��DELETE{int id}��6$   $
��Left=�6=   $��438,302,0,0q�6X   $	��Top=�6m   $	��331��6�   6�   5      5      