   M S B A M L   `   `   `  ????E  AKaritasWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:KaritasWPF
KaritasWPF  5   	       KaritasWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:KaritasWPF     5   	     ? Title$  
MainWindow??5   	   $	??409??6   $	??358??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6   .+?5   
   ?? $??Zap.št??6   $??0??6"   $??0??6/   ?? 5   
   -   5        $??	txtZapŠt??5      $??0??6"   $??1??6/   ?? 5   
   $??Datum??6   $??0??6!   $??1??62   (  "System.Windows.Controls.DatePicker  5   
   -   5        $??dtpDatum??5      $??1??6%   $??1??66      SelectedDate 6C   ?? *DisplayDate+ ?? ElementName$ dtpDatum???? 5   
   $??Namen??6   $??2??6!   $??0??6.   ?? 5   
   -   5        $??txtNamen??5      $??2??6"   $??1??6/   ?? 5   
   $??Znesek??6   $??3??6"   $??0??6/   ?? 5   
   -   5        $??	txtZnesek??5      $??3??6#   $??1??60   ?? 5   
   $??Opombe??6   $??4??6"   $??0??6/   ?? 5    
   -   5        $??	txtOpombe??5       $??4??6#   $??1??60   ?? 5!   
   -   5        $??Vnesi??5!      $??5??6!   $??1??6.   6>   5#      5$      