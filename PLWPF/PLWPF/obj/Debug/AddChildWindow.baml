   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.AddChildWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  AddChildWindow��5	   	   $��333.333��6    $��335.802��61   .��5
      � .+�5   
   �� -   5        $��	Add Child��5      $
��Left=�6%   $��41��6@   $��-6,263,-5,-2q�6L   $	��Top=�6b   $	��339��6z   6�   � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��	36,17,0,0q�6:   $	��Top=�6M   $	��202��6e   $	��237��6r    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Birth Date:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��0��6`   $��Center=�6m   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ birthDateDatePicker��5      $��1��66   $
��Left=�6F   $��3q�6a   $��0��6l   $��Center=�6�      SelectedDate 6y   �� *	BirthDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 5      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��1��6`   $��Center=�6m   �� 5      -   5        	 ��Name$	 firstNameTextBox��5      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��1��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+$ TwoWay=� .  . 6�   �� 5      $	��ID:��6   $��0��6"   $
��Left=�62   $��3q�6M   $��2��6X   $��Center=�6e   �� 5      -   5        $	 	iDTextBox��5      $��1��6)   $
��Left=�69   $��23��6T   $��3q�6`   $��2��6k   $��Center=�6�   $	��120��6�   ��6x   �� *ID+$ TwoWay=� .  . 6�   �� 5      $��
Mother ID:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��3��6_   $��Center=�6l   �� 5       -   5        $	 motherIDTextBox��5       $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��3��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
MotherID+$ TwoWay=� .  . 6�   �� 5!      $��Needs:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��4��6[   $��Center=�6h   �� 5"      -   5        $	 needsTextBox��5"      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��4��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Needs+$ TwoWay=� .  . 6�   5#      5%      5&      