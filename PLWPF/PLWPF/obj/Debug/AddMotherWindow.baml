   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.AddMotherWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  AddMotherWindow��5	   	   $��854.71��6!   $��445.557��61   .��5
      �� $��7,0,0,-4q�6   .��5   
   � $	��723��6   $	��Top=�6   $	��410��64    J� RenderTransformOrigin$ 0.803,0.507&�6@    � RowDefinitions 5      �� 5      .+�5      � -   5         �Name$ grid1��5      $
��Left=�6"   $��	51,26,0,0q�6=   $	��Top=�6P   $	��672��6h   $	��235��6u    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'    5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5       $
��Auto �6$   �� 5!      $
��Auto �6$   �� 5"      $
��Auto �6$   �� 5#      $
��Auto �6$   �� 5$      $
��Auto �6$   �� 5%      $
��Auto �6$   �� 5&      $
��Auto �6$   �� 5'      $
��Auto �6$   �� 5(      $
��Auto �6$   �� 5)      $
��Auto �6$   .+�5,      �� $��Birth Date:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   (  "System.Windows.Controls.DatePicker  5-      -   5          Name$ birthDateDatePicker��5-      $��1��6:   $
��Left=�6J   $��3q�6e   $��0��6p   $��Center=�6�      SelectedDate 6}   �� *	BirthDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6�   �� 5.      $��First Name:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��1��6d   $��Center=�6q   �� 5/      -   5        
 ��Name$
 firstNameTextBox��5/      $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��1��6v   $��Center=�6�   $	��120��6   ��6�   �� *	FirstName+$ TwoWay=� . 	 . 6   �� 50      $	��ID:��6   $��0��6&   $
��Left=�66   $��3q�6Q   $��2��6\   $��Center=�6i   �� 51      -   5        $
 	iDTextBox��51      $��1��6-   $
��Left=�6=   $��23��6X   $��3q�6d   $��2��6o   $��Center=�6�   $	��120��6�   ��6|   �� *ID+$ TwoWay=� . 	 . 6�   �� 52      $��	Lastname:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��3��6b   $��Center=�6o   �� 53      -   5        $
 lastnameTextBox��53      $��1��63   $
��Left=�6C   $��23��6^   $��3q�6j   $��3��6u   $��Center=�6�   $	��120��6�   ��6�   �� *
Lastname+$ TwoWay=� . 	 . 6�   �� 54      $
��Tel:��6   $��0��6'   $
��Left=�67   $��3q�6R   $��4��6]   $��Center=�6j   �� 55      -   5        $
 
telTextBox��55      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��4��6p   $��Center=�6�   $	��120��6�   ��6}   �� *Tel+$ TwoWay=� . 	 . 6�   �� 56      $��Tel Nossaf:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��5��6d   $��Center=�6q   �� 57      -   5        $
 telNossafTextBox��57      $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��5��6v   $��Center=�6�   $	��120��6   ��6�   �� *	TelNossaf+$ TwoWay=� . 	 . 6   �� 58      $��City:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��6��6^   $��Center=�6k   �� 59      -   5        $
 cityTextBox��59      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��6��6q   $��Center=�6~   $	��120��6�   �� 5:      $��Country:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��7��6a   $��Center=�6n   �� 5;      -	   5        $
 countryTextBox��5;      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��7��6t   $��Center=�6�   $	��120��6�   �� 5<      $��Number:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��8��6`   $��Center=�6m   �� 5=      -
   5        $
 numberTextBox��5=      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��8��6s   $��Center=�6�   $	��120��6�   �� 5>      $��Street:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��9��6`   $��Center=�6m   �� 5?      -   5        $
 streetTextBox��5?      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��9��6s   $��Center=�6�   $	��120��6�   �� 5@      $��	Zip Code:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��10��6b   $��Center=�6p   �� 5A      -   5        $
 zipCodeTextBox��5A      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��10��6t   $��Center=�6�   $	��120��6�   �� 5B      $��Account Number:��6   $��0��62   $
��Left=�6B   $��3q�6]   $��11��6h   $��Center=�6v   �� 5C      -   5        $
 accountNumberTextBox��5C      $��1��68   $
��Left=�6H   $��23��6c   $��3q�6o   $��11��6z   $��Center=�6�   $	��120��6  ��6�   �� *BankDetails.AccountNumber+$ TwoWay=� . 	 . 6  �� 5D      $��Balance:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��12��6a   $��Center=�6o   �� 5E      -   5        $
 balanceTextBox��5E      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��12��6t   $��Center=�6�   $	��120��6	  ��6�   �� *BankDetails.Balance+$ TwoWay=� . 	 . 6	  �� 5F      $��Bank Branch:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��13��6e   $��Center=�6s   �� 5G      -   5        $
 bankBranchTextBox��5G      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��13��6w   $��Center=�6�   $	��120��6  ��6�   �� *BankDetails.BankBranch+$ TwoWay=� . 	 . 6  �� 5H      $��
Bank Name:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��14��6c   $��Center=�6q   �� 5I      -   5        $
 bankNameTextBox��5I      $��1��63   $
��Left=�6C   $��23��6^   $��3q�6j   $��14��6u   $��Center=�6�   $	��120��6  ��6�   �� *BankDetails.BankName+$ TwoWay=� . 	 . 6  �� 5J      $��Bank Number:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��15��6e   $��Center=�6s   �� 5K      -   5        $
 bankNumberTextBox��5K      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��15��6w   $��Center=�6�   $	��120��6  ��6�   �� *BankDetails.BankNumber+$ TwoWay=� . 	 . 6  �� 5L      $��City:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��16��6^   $��Center=�6l   �� 5M      -   5        $
 cityTextBox1��5M      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��16��6r   $��Center=�6�   $	��120��6�   �� 5N      $��Country:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��17��6a   $��Center=�6o   �� 5O      -   5        $
 countryTextBox1��5O      $��1��63   $
��Left=�6C   $��23��6^   $��3q�6j   $��17��6u   $��Center=�6�   $	��120��6�   �� 5P      $��Number:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��18��6`   $��Center=�6n   �� 5Q      -   5        $
 numberTextBox1��5Q      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��18��6t   $��Center=�6�   $	��120��6�   �� 5R      $��Street:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��19��6`   $��Center=�6n   �� 5S      -   5        $
 streetTextBox1��5S      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��19��6t   $��Center=�6�   $	��120��6�   �� 5T      $��	Zip Code:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��20��6b   $��Center=�6p   �� 5U      -   5        $
 zipCodeTextBox1��5U      $��1��63   $
��Left=�6C   $��23��6^   $��3q�6j   $��20��6u   $��Center=�6�   $	��120��6�   5V      �� 5W      -   5         ��Name$ 
Add_Mother��5W      $��
Add Mother��6)   $
��Left=�6>   $��30��6Y   $��23,771,0,-78q�6e   $	��Top=�6{   $	��317��6�   6�   �� 5X      $��Button��6   $
��Left=�6&   $��33��6A   $��56,726,0,-36q�6M   $	��Top=�6c   $	��244��6{   5[      5\      5]      