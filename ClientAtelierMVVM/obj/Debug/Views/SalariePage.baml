   M S B A M L   `   `   `  ����L  HClientAtelierMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ClientAtelierMVVM.ViewsClientAtelierMVVM.Views  5      )    #ClientAtelierMVVM.Views.SalariePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ClientAtelierMVVM.Views     5        N� Title$  SalariePage��5	      .��5      � 
����� �.+�5   
   �� -   5         ��Name$ tbxNom��5      $
��Left=�6#   $��23��6>   $��
132,14,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�5   6   $	��120��6N   ��6   ��  �� Path$ SalarieVM.Nom�6N   �� 5   
   -   5        $ 	tbxPrenom��5      $
��Left=�6%   $��23��6@   $��
132,42,0,0q�6L   $
 Wrap=�6`   $	��Top=�5   9   $	��120��6Q   ��6   �� $ SalarieVM.Prenom�6Q   �� 5   
   -   5        $ tbxLieuxdeNaissance��5      $
��Left=�6/   $��23��6J   $��
132,98,0,0q�6V   $
 Wrap=�6j   $	��Top=�5   @   $	��120��6X   ��6   �� $ SalarieVM.LieuNaissance�6X   �� 5   
   -   5        $ 
tbxAdresse��5      $
��Left=�6&   $��23��6A   $��132,126,0,0q�6M   $
 Wrap=�6b   $	��Top=�5   :   $	��120��6R   ��6   �� $ SalarieVM.Adresse�6R   �� 5   
   -   5        $ tbxTypeDeContrat��5      $
��Left=�6,   $��23��6G   $��132,154,0,0q�6S   $
 Wrap=�6h   $	��Top=�5   >   $	��120��6V    J� RenderTransformOrigin$ 0.494,0.456&�6b   ��6   �� $ SalarieVM.TypeContrat�6b   �� 5   
   $��Nom : ��6   $
��Left=�6!   $��	10,10,0,0q�6<   $	��Top=�6O   $��23��6g   �� 5   
   $��	Prenom : ��6   $
��Left=�6$   $��	10,42,0,0q�6?   $	��Top=�6R   $��23��6j   �� 5   
   $��Date de Naissance : ��6   $
��Left=�6/   $��	10,70,0,0q�6J   $	��Top=�6]   $��23��6u   �� 5   
   $��Lieu de Naissance : ��6   $
��Left=�6/   $��	10,98,0,0q�6J   $	��Top=�6]   $��23��6u   �� 5   
   $��
Adresse : ��6   $
��Left=�6%   $��
10,126,0,0q�6@   $	��Top=�6T   $��23��6l   �� 5   
   $��Type de Contrat : ��6   $
��Left=�6-   $��	9,154,0,0q�6H   $	��Top=�6[   $��23��6s   �� 5   
   $��Photo : ��6   $
��Left=�6#   $��	9,182,0,0q�6>   $	��Top=�6Q   $��23��6i   �� 5   
   -   5         ��Name$ imgImage��5      $
��Left=�6_   $	��183��6z   $��270,182,0,0q�6�   $	��Top=�6�   $	��216��6�    J� OpacityMask �	#FFE42121��6$   �� $ SalarieVM.PhotoProfil� �� Mode$ TwoWay=�6�   �� 5   
   -   5         ��Name$ btnImage��5      $��Image��6#   $
��Left=�63   $��132,185,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5    
   -   5        $ 
btnAjouter��5       $��Ajouter��5!   h   $
��Left=�6z   $��	0,210,0,0q�6�   $	��Top=�6�   $	��252��6�   $��28��6�   ��6   �� $ CreationSalarieVM���6<   �� $ 	SalarieVM�6�   (  "System.Windows.Controls.DatePicker  5"   
   -	   5        	  Name$	 dtpDateNaissance��5"      $
��Left=�5#   M   $��
132,71,0,0q�6h   $	��Top=�6|   
   SelectedDate
 6   �� $ SalarieVM.DateNaissance�6|   5%      5&      