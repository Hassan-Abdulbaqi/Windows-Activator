﻿Imports XylonV2
Imports System.Text.RegularExpressions
Imports XylonV2.Engine.Reg

Public Class Form1

    Public Shared windows_Keys As String = <a><![CDATA[
##################$
#OS|Type|Brand|Key$
##################$
Vista|Ultimate|Acer|3YDB8-YY3P4-G7FCW-GJMPG-VK48C$
Vista|Ultimate|Advent|39MVW-K8KKQ-BGJ9B-24PMW-RYQMV$
Vista|Ultimate|Alienware|7QVFM-MF2DT-WXJ62-XTYX3-P9YTT$
Vista|Ultimate|Asus|6F2D7-2PCG6-YQQTB-FWK9V-932CC$
Vista|Ultimate|Dell|2QBP3-289MF-9364X-37XGX-24W6P$
Vista|Ultimate|DixonsXP|6JPQR-4G364-2B7P7-83FXW-DR8QC$
Vista|Ultimate|Gateway|6P8XK-GDDTB-X9PJQ-PYF36-G8WGV$
Vista|Ultimate|Hedy|7R2C3-DWCBG-C8G96-MPT8T-K37C7$
Vista|Ultimate|HP|23CM9-P7MYR-VFWRT-JGH7R-R933G$
Vista|Ultimate|Lenovo|24J6Q-YJJBG-V4K4Q-2J8HY-8HBQQ$
Vista|Ultimate|OQO|C4QGV-XHYYT-9PW8R-DCFTQ-FBD6M$
Vista|Ultimate|Toshiba|33G3W-JY3XQ-CQQ7C-TG96R-R6J6Q$
Vista|Ultimate|Sony|2KKTK-YGJKV-3WMRR-3MDQW-TJP47$
Vista|Ultimate|Stone|GVV4P-RQXD7-X9XKB-M2G9H-C93VM$
Vista|Ultimate|Velocity Micro|9BKKK-7Y888-MHD67-HHXTB-332K9$
Vista|Business|Acer|2TJTJ-C72D7-7BCYH-FV3HT-JGD4F$
Vista|Business|Asus|72PFD-BCBK8-R7X4H-6F2XJ-VVMP9$
Vista|Business|Dealin|HKYB8-CGVG9-6BXG6-6TXY7-HPB8C$
Vista|Business|Dell|368Y7-49YMQ-VRCTY-3V3RH-WRMG7$
Vista|Business|Fujitsu|4C3CM-H3RXM-VBMVQ-K8RHX-RTFX8$
#Vista|Business|Fujitsu Siemens|38BCP-97PJ6-3FRD8-YWWKH-9BJJ2$
Vista|Business|Gateway|9GK24-BJJPV-93JB4-9CD3T-QTHDD$
Vista|Business|HP|2Q2WM-VCB98-8C6BG-C9BT2-3XDRY$
Vista|Business|Lenovo|2YRV9-YCY3F-FRJ4T-BKD6B-C47PP$
Vista|Business|Maxdata|6PYCH-C2YYF-6B867-7BBJ7-HF483$
Vista|Business|MSI|2X4F8-Y4QGK-Y8RTT-CK6PB-M8X92$
Vista|Business|NEC|22QYD-YQFQG-4P9GY-DRVR3-RCFDV$
Vista|Business|OQO|KBK7F-XCVK4-9W477-GPFVC-YXFDM$
Vista|Business|Panasonic|246PH-B8XYM-B7DFM-RR8PM-JRHXC$
Vista|Business|Sony|3W2Y2-GRRYB-VH76X-KPDXX-XFJ4B$
Vista|Business|Stone|6GGKW-TTMHR-P3TPK-6YCCX-C67QY$
Vista|Business|Tarox|BCPKX-GXW2B-7MGWJ-DYQWY-8YMJR$
Vista|Business|Toshiba|38MK6-4QYC6-GJQQX-9DYQ4-H9MQD$
Vista|Business|Xplore|RBYBB-J3BXK-29YD6-JGWQC-TR66P$
Vista|BusinessN|Acer|2434H-HFRM7-BHGD4-W9TTD-RJVCH$
Vista|HomeBasic|Acer|2W7FD-9DWCB-Q9CM8-KTDKK-8QXTR$
Vista|HomeBasic|Asus|762HW-QD98X-TQVXJ-8RKRQ-RJC9V$
Vista|HomeBasic|Benq|7R997-DXYDR-YGCR3-RHVDP-T8TKX$
Vista|HomeBasic|CHS|2QM7G-GTFJ4-2DTTG-R73YR-W3D8G$
Vista|HomeBasic|Dell|3YMR2-WMV49-4WD8X-M9WM7-CH4CG$
Vista|HomeBasic|DixonsXP|6JW74-RXFX8-Y6GC8-BJMRH-9TYH4$
Vista|HomeBasic|Fujitsu|4G8P7-TVW66-Y3H3V-C4Q4J-CQR2B$
#Vista|HomeBasic|Fujitsu Siemens|48382-QY4WK-2JJ3Q-RV8P3-T9WVM$
Vista|HomeBasic|Gateway|7Q3BC-897QP-6HVMF-TTJ34-P92J4$
Vista|HomeBasic|Gericom|MDRBF-FKHJB-6J8RV-P4GKQ-G6BR8$
Vista|HomeBasic|Gigabyte|889T3-F4VGX-QK4V7-JH76R-3HHRC$
Vista|HomeBasic|Higraded|88KB2-RJP4Q-J33P7-8GPWQ-K4HR7$
Vista|HomeBasic|HP|2VX48-BVXT6-GD2PK-BD3R2-44MV3$
Vista|HomeBasic|Kohjinsha|FKHYC-J2FJB-9BRY6-TV8KB-FQJDM$
Vista|HomeBasic|Ksystem-Irbis|J2QKK-V8M3X-WRPPT-FBW4B-FQ6FP$
Vista|HomeBasic|Lenovo|2WP98-KHTH2-KC7KG-4YR37-H8PHC$
Vista|HomeBasic|LG|6DT3K-TCY4G-Y2VK9-T8J3T-2RGT7$
Vista|HomeBasic|Mecer|C3MXB-T6PGC-2M2XV-C6PRX-TPW79$
Vista|HomeBasic|Medion|3XFY9-7GTXV-93RXP-V62MQ-84WP6$
Vista|HomeBasic|NEC|2432B-Q9RGP-VT9CK-64JFP-X6XVT$
Vista|HomeBasic|Packard Bell|4GW2B-QCB6W-BWTVG-2DDKY-KRDMH$
Vista|HomeBasic|Rover|BMHBK-PJD8J-WDWGY-Q4D6Q-46YJP$
Vista|HomeBasic|Samsung|27WDG-2G9G2-BTVMF-W4KCX-9F8PX$
Vista|HomeBasic|Sony|4DWY4-M6VH9-Y6FX6-D2H3V-3PXM9$
Vista|HomeBasic|Stone|6FWK2-27DM3-F9299-CBT83-KJH6M$
Vista|HomeBasic|Toshiba|4DV48-MFJR8-VRW92-3VTYM-HBTPB$
Vista|HomeBasic|Trigem|2YY8K-6KVM4-3DTT6-XRFHK-RYYDG$
Vista|HomeBasicN|Acer|22TC9-RDMDD-VXMXD-2XM2Y-DT6FX$
Vista|HomePremium|Acer|2TYBW-XKCQM-XY9X3-JDXYP-6CJ97$
Vista|HomePremium|Alienware|D9CRD-R8YYQ-VYG3W-YG4FK-2CXRF$
Vista|HomePremium|Asus|8XPM9-7F9HD-4JJQP-TP64Y-RPFFV$
Vista|HomePremium|Dell|4GPTT-6RYC4-F4GJK-KG77H-B9HD2$
Vista|HomePremium|DixonXP|7VJMY-XWBMV-T3PCK-3FRWY-KKMRQ$
Vista|HomePremium|Everex|BH3M9-MQPD8-PTPDK-T6DWK-B2XFW$
Vista|HomePremium|Founder|C6KM8-8JDBT-QBRM8-2MGFH-XH7QY$
Vista|HomePremium|Fujitsu|6M66G-C2BGD-XGBBV-2BHKV-C9KM3$
#Vista|HomePremium|Fujitsu Siemens|4HVQB-W34KM-WRM6D-3RPXT-2V7GR$
Vista|HomePremium|Gateway|6DX2X-QR7XB-3RBY2-BGQ2R-DR9M6$
Vista|HomePremium|HCL|D78T4-HWQ7V-B268D-2TM2G-WCMXP$
Vista|HomePremium|HP|HW7V9-XYT4W-PFR9Q-2DKGJ-RR4TD$
Vista|HomePremium|iQon|6R99P-3HY62-7XR3F-WGP2T-HKCB9$
Vista|HomePremium|Kohjinsha|HRCXG-RQPBQ-YBP92-KFFRY-JKQQ3$
Vista|HomePremium|Ksystem-Irbis|7QVBM-X4KG7-QCWDP-YC8PQ-PXKH8$
Vista|HomePremium|Lenovo|34BKK-QK76Y-WWR7C-QF2M7-2TB37$
Vista|HomePremium|LG|73JC4-PR3R6-9DKYC-FDG3K-3FTT3$
Vista|HomePremium|Maxdata|7VVCR-V82HR-RVT88-CT874-GWHD7$
Vista|HomePremium|Medion|4FG94-MMYPT-H2QD2-V4DCP-X7QB8$
Vista|HomePremium|MeshPC|HR3TD-CH9JD-CT8WF-X948R-C3QR3$
Vista|HomePremium|MSI|86C2J-2M84W-HBMRQ-GBJWJ-VPTRM$
Vista|HomePremium|NEC|22CTR-JFKJJ-BMXQK-XKXBC-C8R98$
Vista|HomePremium|Optima|863XK-7RW2B-6R8CR-4FYQV-3FTW8$
Vista|HomePremium|Packard Bell|6PFJK-WKXQR-9Q27C-6CWD7-MQ3CQ$
Vista|HomePremium|Paradigit|6DX4V-3CJX6-97XGD-KW4C2-PVRRK$
Vista|HomePremium|Powerspec|CK82T-QVTHF-8HGMF-9F3G9-FJH92$
Vista|HomePremium|Quanmax|88XKM-J69QV-VB9M9-QCM66-647KW$
Vista|HomePremium|Samsung|2MQH8-77KBM-PRTT7-HVDWW-DCXVT$
Vista|HomePremium|Sony|6JWV3-843DD-4GV68-6D8JB-G6MF9$
Vista|HomePremium|Stone|762YD-2M884-9YDC4-WRWG9-XT94R$
Vista|HomePremium|Targa|6VJ7B-3KTJH-H3DDQ-7JD7G-26VMG$
Vista|HomePremium|Tarox|D7M9R-VDKX2-HQ27D-RMTH7-QKR98$
Vista|HomePremium|TCL|BH626-XT3FK-MJKJH-6GQT2-QXQMF$
Vista|HomePremium|TriGem|3XKCD-RBHB2-JK77Y-WVW69-7P6VM$
Vista|HomePremium|Toshiba|6DG3Y-99KMR-JQMWD-2QJRJ-RJ34F$
Vista|HomePremium|Velocity|GCHCQ-WTYXJ-GDJBC-JYDCX-F9VXW$
Vista|HomePremium|ZT Systems|FHXBQ-BC3P3-DRMJK-HM72G-BVBQB$
Vista|Starter|Acer|26VQB-RP3T9-63FVV-VD7RF-H7M2Q$
Vista|Starter|HP|223JH-DDMFR-3WBTR-H3V93-28JK8$
Vista|Starter|Lenovo|23Q4W-YQPHY-TY89Y-7Q3VX-W72KT$
Server8R2|ServerStandard|Dell|2FND4-FCR66-RK9Q3-F82H3-4GB43$
#Server8R2|ServerSolution|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
#Server8R2|ServerWinFoundation|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
#Server8R2|ServerDatacenter|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
#Server8R2|ServerStorageStandard|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
#Server8R2|ServerStorageWorkgroup|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
#Server8R2|ServerCloudStorage|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
#Server8R2|ServerWeb|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
Server8|ServerStandard|Unknown|VDNYM-JBKJ7-DC4X9-BT3QR-JHRGY$
Server8|ServerSolution|Unknown|MXHGN-GRJQH-K7WVV-MTXP3-YBFHT$
Server8|ServerWinFoundation|Unknown|RTMNG-7K8HQ-3QVVW-W8QKF-Q9H7D$
Server8|ServerDatacenter|Dell|2BVGY-TNRWK-6927W-866R9-66J3H$
Server8|ServerStorageStandard|Unknown|N67T9-R7KXM-CJKJB-BHGCW-CPKW6$
Server8|ServerStorageWorkgroup|Unknown|CDNBD-9X68R-RRFYH-8G28W-82KXC$
Server8|ServerMultiPointStandard|Unknown|NDQGD-9X68R-RRFYH-8GB8W-82KWG$
Server8|ServerMultiPointPremium|Unknown|RTDKG-7K8HQ-3QVVW-W8NKF-Q9H43$
ServerV|ServerEnterprise|Dell|26Y2H-YTJY6-CYD4F-DMB6V-KXFCQ$
ServerV|ServerEnterpriseV|Dell|2P643-4GWD9-VCHR2-FD99Y-6VYKW$
ServerV|ServerSBSPrime|Dell|BHFGK-YDHVJ-49M49-FT9B3-WKG8Y$
ServerV|ServerSBSStandard|Dell|76GGM-4MQ6T-XCJH9-6R2XQ-PW2D2$
ServerV|ServerStandard|Dell|223PV-8KCX6-F9KJX-3W2R7-BB2FH$
ServerV|ServerStorageStandard|Dell|264YC-6W6Q8-2W6M9-Q77M8-QYD4J$
Server7|ServerEnterprise|Dell|BKCJJ-J6G9Y-4P7YF-8D4J7-7TCWD$
Server7|ServerEnterprise|Fujitsu|22P9W-86F2J-JTHXK-FMFQ4-2DQDR$
Server7|ServerSBSStandard|HP|2QWT9-FMJ8G-99KPY-4MRQJ-XXX3W$
Server7|ServerSBSStandard|IBM|33QFH-PQK6J-MVFJX-JQQ3F-KF6C3$
Server7|ServerStandard|Dell|D7TCH-6P8JP-KRG4P-VJKYY-P9GFF$
Server7|ServerStandard|Fujitsu|28DQD-GJYMB-HGWV8-V3849-XFT2Q$
Server7|ServerStandard|LaCie|HYKB3-BT8G8-7XR73-HM794-HKKXW$
Server7|ServerWinFoundation|Dell|VMYRB-8BRVQ-KXWFF-334J3-F2WHJ$
Server7|ServerHomeStandard|Western Digital|2MR3D-YKFFT-RTMKG-GMMY8-H79KF$
Server7|ServerHomeStandard|LaCie|24HKG-38D9W-TCG2V-K4G44-RQ2CC$
Server7|ServerSolution|Dell|6PJGG-PHG6F-PF94R-RB7QT-PP7KV$
Server7|ServerDatacenter|Fujitsu|26FXG-KYC7Q-XG29P-T2HFQ-KPF96$
Server7|ServerHomePremium|LaCie|2M74M-6DJHT-Y49MG-22FGH-B6XFP$
7|Ultimate|Acer|FJGCP-4DFJD-GJY49-VJBQ7-HYRR2$
7|Ultimate|Alienware|VQ3PY-VRX6D-CBG4J-8C6R2-TCVBD$
7|Ultimate|Aquarius|76TFX-WPXFM-F3HRC-YJYVB-P6TR4$
7|Ultimate|Asus|2Y4WT-DHTBF-Q6MMK-KYK6X-VKM6G$
7|Ultimate|Dell|342DG-6YJR8-X92GV-V7DCV-P4K27$
7|Ultimate|Fujitsu|9CW99-79BBF-D4M3X-9BK9M-4RPH9$
7|Ultimate|HEDY|6RVBB-93T7R-GKQKQ-YWCJR-2TKPJ$
7|Ultimate|HP|MHFPT-8C8M2-V9488-FGM44-2C9T3$
7|Ultimate|Lenovo|6K2KY-BFH24-PJW6W-9GK29-TMPWP$
7|Ultimate|Samsung|49PB6-6BJ6Y-KHGCQ-7DDY6-TF7CD$
7|Ultimate|Sony|YJJYR-666KV-8T4YH-KM9TB-4PY2W$
7|Ultimate|Stone|76MTG-QMQJQ-46DQR-CHRBB-7K3HD$
7|Ultimate|Tarox|4BRY2-6W9VH-9CM6R-GPKRY-HHVCY$
7|Ultimate|Toshiba|2XQ63-J3P67-9G3JC-FHQ68-8Q2F3$
7|UltimateE|HP|278MV-DKMGJ-F3P9F-TD7Y3-W6G3M$
#7|UltimateN|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
7|Professional|Acer|YKHFT-KW986-GK4PY-FDWYH-7TP9F$
7|Professional|Alienware|4CFBX-7HQ6R-3JYWF-72GXP-4MV6W$
#7|Professional|Alienware|MPC38-VC8FK-TWPXH-TR3XV-T2Y4K$
7|Professional|Aquarius|87MQK-W9Y79-J7M7B-92RTM-MXFJG$
7|Professional|Asus|2WCJK-R8B4Y-CWRF2-TRJKB-PV9HW$
7|Professional|BGH e-Nova|4872B-B4R7J-QWCFR-YH962-RGDRW$
7|Professional|ByteSpeed|32327-2GRQK-M6H8D-2XV93-YYCCF$
7|Professional|CCE|D8VYT-828P6-7V77D-P8VV7-CHC4M$
7|Professional|DakTech|BDX3F-M3WPY-FTKYK-QBVD7-9DXH8$
7|Professional|Dealin|6BJ27-DVBFF-VKQC8-7JPQP-TJKYY$
7|Professional|Dell|32KD2-K9CTF-M3DJT-4J3WC-733WD$
7|Professional|Fujitsu|PT9YK-BC2J9-WWYF9-R9DCR-QB9CK$
7|Professional|Genuine|26QH2-B4V28-CWVMD-38GXQ-WHFYH$
7|Professional|HCL|2QTV2-3CMPP-FQBYK-GRD62-D7XMW$
7|Professional|HP|74T2M-DKDBC-788W3-H689G-6P6GT$
7|Professional|INSYS|BPM2T-G28MM-DYPRD-CDFQB-JG89V$
7|Professional|Itautec|2666Q-HGXKH-DFP6M-7YGBB-BG7Q7$
7|Professional|Kraftway|32HPJ-4XRDR-424C8-DYQM9-GM768$
7|Professional|Lenovo|237XB-GDJ7B-MV8MH-98QJM-24367$
7|Professional|MA Technology|CR3MG-TDDHT-T44X2-K722W-J936F$
7|Professional|Mecer|2WGY7-J3JQT-78CF9-J6DHQ-DJTQW$
7|Professional|MiTAC|2XGJT-GV4QG-QBHPB-D6DBW-DTW9Q$
7|Professional|MSI|2W3CX-YD4YJ-DF9B2-V27M6-77GMF$
7|Professional|Paragon|32M8T-4R8Y9-X7J66-R9W3H-YDT6F$
7|Professional|Positivo|4CMG7-XWKFW-FJQVW-6XBCB-DD9CV$
7|Professional|PowerSpec|6FWJ7-TDRCV-BYTP3-JWB98-9J64J$
7|Professional|Quanmax|84TBR-V3TCM-DC73Q-TDRQ7-WHPJ4$
7|Professional|Samsung|GMJQF-JC7VC-76HMH-M4RKY-V4HX6$
7|Professional|SCC|GP2T3-GKR6W-7PGV2-C97HT-TYBVP$
7|Professional|Seneca|862R9-99CD6-DD6WM-GHDG2-Y8M37$
7|Professional|Shuttle|7K3CD-PXHTK-GDBRW-KH842-F9P3D$
7|Professional|Sony|H9M26-6BXJP-XXFCY-7BR4V-24X8J$
7|Professional|STEG|7RQGM-4BJBD-GM2YY-R2KTT-43HG8$
7|Professional|Stone|4FXT2-THHQK-B7293-VYHKX-3DRPD$
7|Professional|Tangent|CVKKG-87DDK-HK8G2-BYQ72-43KFW$
7|Professional|Tarox|72X79-RQPFF-YGK82-7FF8M-PX4XB$
7|Professional|Toshiba|2V8P2-QKJWM-4THM3-74PDB-4P2KH$
7|Professional|Twinhead|4HRQP-KTBTJ-4R9CX-4DWJ6-QFPFT$
7|Professional|WIPRO|84KJC-W886T-XQ496-YTB7W-46DTY$
7|Professional|Wortmann|6JKVQ-WJTWW-JVPRB-77TGD-2DV7M$
7|Professional|Xplore|H8KMB-DPB9M-P3RYK-7JCGW-X97C3$
7|Professional|Zoostorm|6V27R-JRHC9-9W42J-37TFX-9T8Q7$
7|ProfessionalE|HP|P42PH-HYD6B-Y3DHY-B79JH-CT8YK$
#7|ProfessionalN|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
7|HomePremium|Acer|VQB3X-Q3KP8-WJ2H8-R6B6D-7QJB7$
7|HomePremium|Advent|38JTJ-VBPFW-XFQDR-PJ794-8447M$
7|HomePremium|Alienware|V3Y2W-CMF9W-PGT9C-777KD-32W74$
7|HomePremium|Aquarius|P4QBJ-CHBR8-8BK3H-TQXG4-CDPHM$
7|HomePremium|Asus|2QDBX-9T8HR-2QWT6-HCQXJ-9YQTR$
#7|HomePremium|Asus Eee|7JQWQ-K6KWQ-BJD6C-K3YVH-DVQJG$
7|HomePremium|BenQ|7YGK7-YFP3F-6H86R-BWCBV-FBMHW$
7|HomePremium|ByteSpeed|PW872-CKFH7-JVK3G-68XXT-X2BDV$
7|HomePremium|Dealin|8YDX9-B7MMG-82XD9-V88G9-MR92T$
7|HomePremium|Dell|6RBBT-F8VPQ-QCPVQ-KHRB8-RMV82$
7|HomePremium|EXO|GRDX4-HGYJQ-CWJ6B-3HVT2-YKRG4$
7|HomePremium|Fujitsu|C6MHH-TRRPT-74TDC-FHRMV-XB88W$
7|HomePremium|Genuine|2V36J-4RK8B-GW27Q-4DXPG-RQP78$
7|HomePremium|Gigabyte|3743C-T6892-B4PHM-JHFKY-4BB7W$
7|HomePremium|HCL|39QDH-D7MHH-WDMTD-TM2R9-KM7DB$
7|HomePremium|HP|4FG99-BC3HD-73CQT-WMF7J-3Q6C9$
7|HomePremium|Impression Computers|P434X-9H862-PTK88-YGH82-G3THD$
7|HomePremium|INSYS|HT89B-V9F8T-TJQP6-7DB4P-WYPY9$
7|HomePremium|Jetway|J8DTW-BFYQK-QDQ64-RHWB3-CC9WR$
7|HomePremium|Kraftway|6H6K2-Y6CVC-PR6BK-WQ2WP-TJVJ9$
7|HomePremium|Lenovo|27GBM-Y4QQC-JKHXW-D9W83-FJQKD$
7|HomePremium|LG|38GRR-KMG3D-BTP99-TC9G4-BBDJJ$
7|HomePremium|MA Technology|P88MP-94P37-G242D-B68GR-23RWC$
7|HomePremium|Medion|2P2P9-CM3F8-FTV6P-PC7CX-8TFF7$
7|HomePremium|Midern|2J2K4-6WWJT-V44PT-TVDP9-XP7RF$
7|HomePremium|MSI|4G3GR-J6JDJ-D96PV-T9B9D-M8X2Q$
7|HomePremium|ONKYO|6WMCP-JJHVF-GK796-9JB9X-BFX3R$
7|HomePremium|Packard Bell|VQB3X-Q3KP8-WJ2H8-R6B6D-7QJB7$
7|HomePremium|Paradigit|J84PD-BHP6K-FCHBJ-7PHWD-76MXK$
7|HomePremium|Philco|TTJQ7-4PFJC-6JFJ8-B22VD-VXW88$
7|HomePremium|Quanmax|BHJWK-9K4HP-M9DQ2-XX3DR-CJFMR$
7|HomePremium|Samsung|CQBVJ-9J697-PWB9R-4K7W4-2BT4J$
7|HomePremium|Shuttle|C3V4C-6Y6WM-DGRM9-QJG82-8K3FP$
7|HomePremium|Siragon|HWDFB-YVFG4-3TJ7F-Q3WMT-7B6PH$
7|HomePremium|Sony|H4JWX-WHKWT-VGV87-C7XPK-CGKHQ$
7|HomePremium|Stone|86DTG-C7PDC-JDHKH-PGDM7-V9FVY$
7|HomePremium|Systemax|BD778-VXDGJ-X233M-Q839T-VJ3BG$
7|HomePremium|Tarox|BWHCT-BWJPG-H9PV3-4V4WT-9978X$
7|HomePremium|Toshiba|6B88K-KCCWY-4F8HK-M4P73-W8DQG$
7|HomePremium|Viewsonic|C23T3-9F2T2-FPWBM-XYMW2-272J9$
7|HomePremium|ZT Systems|83BJB-QKYF3-H9K4M-DV32X-8X2XD$
7|HomePremiumE|HP|TD77M-HH38J-FBCB8-8QX7Y-P2QH3$
#7|HomePremiumN|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
7|HomeBasic|Acer|MB4HF-2Q8V3-W88WR-K7287-2H4CP$
7|HomeBasic|Aquarius|BBR6J-XPXCX-9VWXV-V8DY3-VHCCV$
7|HomeBasic|Asus|89G97-VYHYT-Y6G8H-PJXV6-77GQM$
7|HomeBasic|CCE|7Q2DF-C4FJJ-VM98J-VB2X7-VK3Y9$
7|HomeBasic|Dealin|6M78P-JJRQP-9C4RX-RPK7G-3VTH3$
7|HomeBasic|Dell|36T88-RT7C6-R38TQ-RV8M9-WWTCY$
7|HomeBasic|Digimer|7YJQX-48WF4-8267H-8PGK7-C8TTQ$
7|HomeBasic|Founder|7WGMV-QFYXX-64DCG-HQFWM-DWGKY$
7|HomeBasic|Fujitsu|8W3JQ-BP2HY-F47QX-6CQ94-2BKQB$
7|HomeBasic|HCL|2Q4QP-8P4MD-47YBP-7TXX9-FKDRM$
7|HomeBasic|HP|DX8R9-BVCGB-PPKRR-8J7T4-TJHTH$
7|HomeBasic|Itautec|239PK-QV6BM-6BX3V-KH2BD-R3VTY$
7|HomeBasic|Jeyway|C4GTY-J39Y2-YVFQJ-DBT27-9MTDW$
7|HomeBasic|Kraftway|2YB9V-B4R3R-D8Y6R-CB7DB-J6YY7$
7|HomeBasic|KSystems|82P6X-KGH24-FCPXC-XQKC9-74KC8$
7|HomeBasic|Lenovo|22MFQ-HDH7V-RBV79-QMVK9-PTMXQ$
7|HomeBasic|Megaware|3YGXR-7CH3C-T3FCG-9CPP2-CQGM4$
7|HomeBasic|MSI|2TY7W-H4DD4-MB62F-BD9C3-88TM6$
7|HomeBasic|Positivo|4FW6G-J7FR9-MHWGW-JDXP6-QQH89$
7|HomeBasic|Samsung|2P6PB-G7YVY-W46VJ-BXJ36-PGGTG$
7|HomeBasic|Sony|YV7QQ-RCXQ9-KTBHC-YX3FG-FKRW8$
7|HomeBasic|Stone|6DG93-2G6YJ-VHRX8-3YRWX-K4HWP$
7|HomeBasic|Tongfang|9DBMT-GXRWM-6Q9Y3-WMYM8-FJCBW$
7|HomeBasic|Toshiba|9H4FH-VD69Y-TGBD2-4PM4K-DRMMH$
#7|HomeBasicE|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
#7|HomeBasicN|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXXv
7|Starter|Acer|RDJXR-3M32B-FJT32-QMPGB-GCFF6$
7|Starter|AOC|C6TY4-9C233-D8VJ2-K34HQ-QTQ9K$
7|Starter|Aquarius|CYXM7-YHGFJ-K7HTJ-RYBBF-GXFMM$
7|Starter|Asus|6K6WB-X73TD-KG794-FJYHG-YCJVG$
7|Starter|ByteSpeed|BJT7H-6YTP7-YJFFH-84HMQ-BRPW2$
7|Starter|Casper ERA|6PB94-MC2C6-4F37H-KTJ32-PF2PT$
7|Starter|CCE|6CYKC-TDDYQ-K4B6G-HQD89-CWDP3$
7|Starter|Crea|4FQRW-9R6H7-6P49K-2QKW6-WVK46$
7|Starter|Dealin|49GDY-XFVJM-877J9-YPQD4-2V72D$
7|Starter|Dell|36Q3Y-BBT84-MGJ3H-FT7VD-FG72J$
7|Starter|Excimer|BHP4B-MXP9G-RG7KQ-T8R84-CW3D3$
7|Starter|Exper|4FRH4-WQDGJ-M9HRY-K73D8-RGT3C$
7|Starter|Fujitsu|PMXH9-M23P9-QJJMB-2FWRC-7CDKP$
7|Starter|Hannspree|BRFCY-XMXRV-28JHQ-F6D9B-BV73C$
7|Starter|HP|RH98C-M9PW4-6DHR7-X99PJ-3FGDB$
7|Starter|Ideal|2XVCK-7B4HM-367Q8-6QMKT-V3MCK$
7|Starter|Jetway|D2DVX-RVRK9-BCV86-2H3BF-HT6T2$
7|Starter|KSystems|6KTVJ-RY667-X3Q9J-26MXJ-KKWT8$
7|Starter|Lenovo|273P4-GQ8V6-97YYM-9YTHF-DC2VP$
7|Starter|LG|2V3W2-JXTTR-28RD8-R228D-KR69C$
7|Starter|MA Technology|CVWQ7-6X8QF-VPQ6J-FJF26-QFK7W$
7|Starter|Medion|2K8WH-JVQDM-C9HVC-YR2XC-8M76G$
7|Starter|MSI|2W4DJ-JFFJV-DMCPP-2C3X8-883DP$
7|Starter|Nokia|2XGHP-9TQK2-8CF28-BM2P2-8FRX8$
7|Starter|Olidata|344HQ-3YHDT-C7VCT-BDPBV-4KTR3$
7|Starter|Philco|CPWRQ-6XR63-4VK76-2FGT3-8BC3R$
7|Starter|Positivo|49XPC-DRPCY-QW32T-DDYYR-4CJQ2$
7|Starter|Sony|32J2V-TGQCY-9QJXP-Q3FVT-X8BQ7$
7|Starter|Stone|4BBMG-9W3GV-W48DD-KX6MB-XMMMK$
7|Starter|Tarox|6RVFM-RTMTJ-4DGWV-TXTQW-7GFFB$
7|Starter|Toshiba|TGBKB-9KBGJ-3Y3J6-K8M2F-J2HJQ$
7|Starter|Viewsonic|6TQ9G-QB2WK-FM2TB-CKBDP-9D6HM$
7|Starter|Viliv|7W842-2HCPJ-BC3MJ-B79K6-TD2HQ$
7|Starter|Zoostorm|6JPKB-P8D84-6DT8D-P2QHB-QMKP9$
7|StarterE|HP|C3HY9-34XKR-6Y9Y9-RB7TR-84KWG$
#7|StarterN|Demo|XXXXX-XXXXX-XXXXX-XXXXX-XXXXX$
7|Professional|Universal|FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4$
7|Enterprise|Universal|33PXH-7Y6KF-2VJC9-XBBR8-HVTHH$
8.1|Professional|Universal|GCRJD-8NW9H-F2CDX-CCM8D-9D6T9$
8.1|Enterprise|Universal|MHF9N-XY6XB-WVXMC-BTDCT-MKKG7$
10|Professional|Universal|W269N-WFGWX-YVC9B-4J6C9-T83GX$
10|Enterprise|Universal|NPPR9-FWDCX-D2C8J-H872K-2YT43$
10|Enterprise N|Universal|DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4$
10|Home|Universal|TX9XD-98N7V-6WMQ6-BX7FG-H8Q99$
10|Home N|Universal|3KHY7-WNT83-DGQKR-F7HPR-844BM$
10|Home SL|Universal|7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH$
10|Home CS|Universal|PVMJN-6DFY6-9CCP6-7BKTT-D3WVR$
10|Pro|Universal|W269N-WFGWX-YVC9B-4J6C9-T83GX$
10|Pro N|Universal|MH37W-N47XK-V7XM9-C7227-GCQG9$
10|Education|Universal|NW6C2-QMPVW-D7KKK-3GKT6-VCFB2$
10|Education N|Universal|2WH4N-8QGBV-H22JP-CT43Q-MDWWJ$
]]></a>.Value



    Dim productName As String = GetCurrenVersionInfo("ProductName")
    Dim Edition As String = GetCurrenVersionInfo("EditionID")
    Dim OsVersionBAD As Integer = Integer.Parse(Regex.Replace(productName, "[^\d]", ""))
    Dim Manufacturer As String = String.Empty
    Dim PC_Model As String = String.Empty


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ListKeys()
    End Sub

    Private Sub ListKeys()
        ListBox1.Items.Clear()

        Dim WindowsKeys As List(Of KeyType) = Nothing

        If CheckBox1.Checked = True Then
            WindowsKeys = GETKey(OsVersionBAD, Edition, Manufacturer)
        Else
            WindowsKeys = GETKey(OsVersionBAD, Edition)
        End If

        Label5.Text = WindowsKeys.Count

        For Each WindowsK As KeyType In WindowsKeys

            ListBox1.Items.Add(WindowsK.Key)

        Next
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        XylonV2.Modules.Initialization() ' good :)


        Dim ComputerInfo As XylonV2.Core.Engine.WMI.Win32_ComputerSystem = XylonV2.Core.Engine.WMI.Win32_ComputerSystem.GetComputerSystemInfo

        If ComputerInfo IsNot Nothing Then
            Manufacturer = ComputerInfo.Manufacturer
            PC_Model = ComputerInfo.Model
            ' Dim PC_Name As String = ComputerInfo.Name ' or ComputerInfo.UserName (full path)

        End If

        'Dim OsVErsion As Core.WindowsDetection.WinDetect = Core.WindowsDetection.GetOSInfo

        Dim winVersion As String = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString()

        Dim compilation As String = productName.Replace("Windows", "").Replace(OsVersionBAD, "").Replace(" ", "").ToString

        Label3.Text = "Version: " & OsVersionBAD & " Edition: " & Edition & " Manufacturer: " & Manufacturer & " Model: " & PC_Model

        ListBox2.SelectedIndex = 0 ' select the first item

        ListKeys()

    End Sub


    Private Function TestEvaluationVersion(ByVal ProductName As String, ByVal WinVersion As String, ByVal Edition As String, ByVal Key As String) As String
        If ProductName.ToLower().Contains("evaluation") Then
            Dim args As String = "/online /set-edition:Server" & Edition & " /productkey:" & Key & " /accepteula"
            Dim eval2license As String = RunProcess("dism.exe", args, "", False)

            If eval2license = "" Then
            MsgBox("Evaluation version failed to be converted.", "WindowsActivator")
            End If

            Return eval2license
        Else
            Return String.Empty
        End If
    End Function

    Private Function GETKey(ByVal OsVersion As Integer, ByVal Edition As String, Optional ByVal PC As String = "") As List(Of KeyType)
        Dim KeyList As New List(Of KeyType)

        Dim WindowsKeys As List(Of KeyType) = GEtWindowsKeys()

        For Each WindowsK As KeyType In WindowsKeys

            Dim compare As Boolean = (OsVersion = Val(WindowsK.OsVersion))

            If LCase(Edition) = LCase(WindowsK.OsCompilation) Then


                If compare = True Then

                    If PC = "" Then

                        KeyList.Add(WindowsK)

                    Else

                        If PC.Contains(WindowsK.PC, StringComparison.OrdinalIgnoreCase) = True Then ' GEt Windows key By Manufacturer

                            KeyList.Add(WindowsK)

                        ElseIf WindowsK.PC.ToLower = "universal" Then

                            KeyList.Add(WindowsK)

                        End If

                    End If


                End If

            End If


        Next


        Return KeyList
    End Function

    Public Shared Function RunProcess(ByVal name As String, ByVal args As String, ByVal workdir As String, ByVal silent As Boolean) As String
        Dim procInfo As ProcessStartInfo = New ProcessStartInfo With {
            .FileName = name,
            .WorkingDirectory = System.Environment.GetEnvironmentVariable("SystemRoot") & "\System32",
            .Arguments = args
        }

        If workdir <> "" Then
            procInfo.WorkingDirectory = workdir
        End If

        If silent Then
            procInfo.UseShellExecute = False
            procInfo.CreateNoWindow = True
            procInfo.WindowStyle = ProcessWindowStyle.Hidden
            procInfo.RedirectStandardOutput = True
        End If

        Dim proc As Process = New Process With {
            .StartInfo = procInfo
        }

        Try
            proc.Start()
        Catch err As Exception
            MessageBox.Show("RunProcess" & vbLf & err.ToString(), "Exception: ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return ""
        End Try

        Dim output As String = proc.StandardOutput.ReadToEnd().ToLower()
        proc.WaitForExit()
        Return output
    End Function


    Public Function GetCurrenVersionInfo(ByVal TargetInfo As String) As String
        Return RegEdit.GetValueData(Of String)(fullKeyPath:="HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion", valueName:=TargetInfo, registryValueOptions:=Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
    End Function

    Public Function GEtWindowsKeys() As List(Of KeyType)
        Dim NewList As New List(Of KeyType)

        Dim KeysString As String = windows_Keys.ToString


        For Each LineStr As String In KeysString.Split("$") ' wait bro

            If Not LineStr = String.Empty Then

                If Not LineStr.StartsWith("#") Then

                    Dim KeyStringSeparator As String() = LineStr.Split("|")

                    If KeyStringSeparator.Count = 4 Then

                        If KeyStringSeparator(0).Contains("#") = False Then
                            Dim KeyTypeEX As New KeyType

                            KeyTypeEX.OsVersion = KeyStringSeparator(0)
                            KeyTypeEX.OsCompilation = KeyStringSeparator(1)
                            KeyTypeEX.PC = KeyStringSeparator(2)
                            KeyTypeEX.Key = KeyStringSeparator(3)
                            NewList.Add(KeyTypeEX)
                        End If

                    End If

                    'ok
                End If

            End If

        Next

        Return NewList


    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Dim Selecteditem As String = ListBox1.Items(ListBox1.SelectedIndex)
            TextBox1.Text = Selecteditem
            TextBox2.Text = TestEvaluationVersion(productName, OsVersionBAD, Edition, Selecteditem)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Try
            Dim Selecteditem As String = ListBox2.Items(ListBox2.SelectedIndex)
            TextBox3.Text = Selecteditem
        Catch ex As Exception

        End Try
    End Sub
#Region " Active "


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Activewindows(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Unistallkey()
    End Sub

    Private Sub Unistallkey()

        Dim makeVolDbg As String = String.Empty
        Dim comands As String() = {"slmgr.vbs /upk", "slmgr.vbs /cpky", "slmgr.vbs /rearm", "slmgr.vbs /ato"}


        For Each Cmd As String In comands


            Dim activateDbg As String = String.Empty
            Dim kmsServerDbg As String = String.Empty
            Dim makeVol As Process = New Process()
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {
                .FileName = "cscript.exe",
                .WorkingDirectory = System.Environment.GetEnvironmentVariable("SystemRoot") & "\System32",
                .Arguments = "//Nologo " & Cmd,
                .CreateNoWindow = True,
                .UseShellExecute = False,
                .RedirectStandardOutput = True,
                .WindowStyle = ProcessWindowStyle.Hidden
            }
            makeVol.StartInfo = startInfo

            Try
                makeVol.Start()
            Catch err As Exception
            MessageBox.Show(err.ToString(), "Exception: ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            End Try

            makeVolDbg += makeVol.StandardOutput.ReadToEnd() & vbNewLine
            makeVol.WaitForExit()

        Next
        Me.BeginInvoke(Function()
                           TextBox2.Text = makeVolDbg
                       End Function)
    End Sub

    Private Sub Activewindows(ByVal key As String, ByVal Server As String)
        Dim makeVolDbg As String = String.Empty
        Dim activateDbg As String = String.Empty
        Dim kmsServerDbg As String = String.Empty
        Dim makeVol As Process = New Process()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {
            .FileName = "cscript.exe",
            .WorkingDirectory = System.Environment.GetEnvironmentVariable("SystemRoot") & "\System32",
            .Arguments = "//Nologo slmgr.vbs /ipk " & key,
            .CreateNoWindow = True,
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .WindowStyle = ProcessWindowStyle.Hidden
        }
        makeVol.StartInfo = startInfo

        Try
            makeVol.Start()
        Catch err As Exception
            MessageBox.Show(err.ToString(), "Exception: ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try

        makeVolDbg = makeVol.StandardOutput.ReadToEnd()
        makeVol.WaitForExit()

        'KMS

        Me.BeginInvoke(Function()
                           startInfo.Arguments = "//Nologo slmgr.vbs /skms " & Server
                       End Function)
        Dim kmsServer As Process = New Process With {
            .StartInfo = startInfo
        }
        kmsServer.Start()
        kmsServerDbg = kmsServer.StandardOutput.ReadToEnd()
        kmsServer.WaitForExit()
        startInfo.Arguments = "//Nologo slmgr.vbs /ato"
        Dim activate As Process = New Process With {
            .StartInfo = startInfo
        }
        activate.Start()
        activateDbg = activate.StandardOutput.ReadToEnd()
        activate.WaitForExit()
        Me.BeginInvoke(Function()
                           Dim debugstr As String = makeVolDbg & vbLf + kmsServerDbg & vbLf + activateDbg
                           TextBox2.Text = debugstr
                       End Function)
    End Sub
#End Region
End Class
