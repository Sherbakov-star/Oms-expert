using System;
using System.ComponentModel;
using Npoi.Mapper.Attributes;

namespace Mee
{
    public class SluchFields
    {
        [Browsable(false)]
        public int RowHandle { get; set; }

        [Column("Id")]
        [Browsable(false)]
        public Guid Id { get; set; }

        [Column("IdTypeReestr")]
        [Browsable(false)]
        public int IdTypeReestr { get; set; }

        [Column("CODE_MO")]
        [Browsable(false)]
        public string CodeMo { get; set; }

        [Column("N_ZAP")]
        [Browsable(false)]
        public int NZap { get; set; }

        [Column("IDCASE")]
        [Browsable(false)]
        public int IDCASE { get; set; }

        [Column("USL_OK")]
        [Browsable(false)]
        public int UslOk { get; set; }

        [Column("VIDPOM")]
        [Browsable(false)]
        public int VidPom { get; set; }

        [Column("W")]
        [Browsable(false)]
        public int W { get; set; }

        [Column("PLAT")]
        [Browsable(false)]
        public string PLAT { get; set; }

        [Column("NPR_MO")]
        [Browsable(false)]
        public string NprMo { get; set; }

        [Column("FOR_POM")]
        [Browsable(false)]
        public string ForPom { get; set; }

        [Column("PROFIL")]
        [Browsable(false)]
        public string Profil { get; set; }

        [Column("DET")]
        [Browsable(false)]
        public int Det { get; set; }

        [Column("DS0")]
        [Browsable(false)]
        public string Ds0 { get; set;}

        [Column("DS1")]
        [Browsable(false)]
        public string Ds1 { get; set; }

        [Column("DS2")]
        [Browsable(false)]
        public string Ds2 { get; set; }

        [Column("DS3")]
        [Browsable(false)]
        public string Ds3 { get; set; }

        [Column("RSLT")]
        [Browsable(false)]
        public int Rslt { get; set; }

        [Column("ISHOD")]
        [Browsable(false)]
        public int Ishod { get; set; }

        [Column("PRVS")]
        [Browsable(false)]
        public int Prvs { get; set; }

        [Column("kd")]
        [Browsable(false)]
        public int Kd { get; set; }

        [Column("IDSP")]
        [Browsable(false)]
        public int Idsp { get; set; }

        [Column("ED_COL")]
        [Browsable(false)]
        public int EdCol { get; set; }

        [Column("KOL_USL")]
        [Browsable(false)]
        public int KolUsl { get; set; }

        [Column("V_TIP")]
        [Browsable(false)]
        public int VTip { get; set; }

        [Column("SMO")]
        [Browsable(false)]
        public int Smo { get; set; }

        [Column("NOVOR")]
        [Browsable(false)]
        public int Novor { get; set; }

        [Column("DOCTYPE")]
        [Browsable(false)]
        public int DocType { get; set; }

        [Column("TypeReestr")]
        [Browsable(false)]
        public string TypeReestr { get; set; }

        [Column("DOCSER")]
        [Browsable(false)]
        public string Docser { get; set; }

        [Column("DOCNUM")]
        [DisplayName("Номер документа")]
        [Category("Пациент")]
        public string Docnum { get; set; }

        [Column("VNOV_D")]
        [Browsable(false)]
        public string Vnovd { get; set; }

        [Column("VID_HMP")]
        [Browsable(false)]
        public string VidHmp { get; set; }

        [Column("METOD_HMP")]
        [Browsable(false)]
        public string MetodHmp { get; set; }

        [Column("MSE")]
        [Browsable(false)]
        public string Mse { get; set; }

        [Column("RSLT_D")]
        [Browsable(false)]
        public string RsltD { get; set; }

        [Column("LPU")]
        [Browsable(false)]
        public string LPU { get; set; }

        [Column("LPU_1")]
        [Browsable(false)]
        public string LPU1 { get; set; }

        [Column("DET1")]
        [Browsable(false)]
        public int DET1 { get; set; }

        [Column("VBR")]
        [Browsable(false)]
        public string Vbr { get; set; }

        [Column("PR_D_N")]
        [Browsable(false)]
        public string Prdn { get; set; }

        [Column("DS_ONK")]
        [Browsable(false)]
        public string DsOnk { get; set; }

        [Column("CRIT")]
        [Browsable(false)]
        public string Crit { get; set; }

        [Column("CODE_USL")]
        [DisplayName("Код услуги")]
        [Category("Информация о случае")]
        public string CodeUsl { get; set; }

        [Column("DS_ONK1")]
        [Browsable(false)]
        public string DsOnk1 { get; set; }

        [Column("INV")]
        [Browsable(false)]
        public int Inv { get; set; }

        [Column("AGE")]
        [DisplayName("Возраст")]
        [Category("Пациент")]
        public int Age { get; set; }

        [Column("COMENTSL")]
        [Browsable(false)]
        public string ComentSl { get; set; }

        [Column("InspectionSluchId")]
        [Browsable(false)]
        public Guid InspectionSluchId { get; set; }

        [Column("ЭКМП")]
        [Browsable(false)]
        public string Ekmp { get; set; }

        [Column("NAME_MO")]
        [Browsable(false)]
        public string  NAME_MO { get; set; }

        [Column("FAM")]
        [Browsable(false)]
        public string FAM { get; set; }

        [Column("IM")]
        [Browsable(false)]
        public string IM { get; set; }

        [Column("OT")]
        [Browsable(false)]
        public string OT { get; set; }

        [Column("DR")]
        [Browsable(false)]
        public DateTime DR { get; set; }

        [Column("NHISTORY")]
        [Browsable(false)]
        public string NHISTORY { get; set; }

        [Column("DATE_1",CustomFormat = "dd.MM.yyyy")]
        [Browsable(false)]
        public DateTime DATE_1 { get; set; }

        [Column("DATE_2", CustomFormat = "dd.MM.yyyy")]
        [Browsable(false)]
        public DateTime DATE_2 { get; set; }

        [Column("Ryear")]
        [DisplayName("Год")]
        [Category("Информация об оплате")]
        public int Ryear { get; set; }

        [Column("Rmonth")]
        [DisplayName("Месяц")]
        [Category("Информация об оплате")]
        public int Rmonth { get; set; }

        [Column("NSCHET")]
        [DisplayName("Номер счета")]
        [Category("Информация об оплате")]
        public string NSCHET { get; set; }

        [Column("DSCHET")]
        [DisplayName("Дата выставления счёта")]
        [Category("Информация об оплате")]
        public DateTime DSCHET { get; set; }

        [Column("VIDPOM_NAME")]
        [DisplayName("Вид помощи")]
        [Category("Информация о случае")]
        public string VIDPOM_NAME { get; set; }

        [Column("PROFIL_NAME")]
        [DisplayName("Профиль")]
        [Category("Информация о случае")]
        public string PROFIL_NAME { get; set; }

        [Column("DS1_NAME")]
        [DisplayName("Диагноз основной")]
        [Category("Информация о случае")]
        public string DS1_NAME { get; set; }

        [Column("RSLT_NAME")]
        [DisplayName("Результат обращения")]
        [Category("Информация о случае")]
        public string RSLT_NAME { get; set; }

        [Column("ISHOD_NAME")]
        [DisplayName("Исход заболевания")]
        [Category("Информация о случае")]
        public string ISHOD_NAME { get; set; }

        [Column("PRVS_NAME")]
        [DisplayName("Специальность лечащего врача")]
        [Category("Информация о случае")]
        public string PRVS_NAME { get; set; }

        [Column("IDDOKT_NAME")]
        [DisplayName("Лечащий врач")]
        [Category("Информация о случае")]
        public string IDDOKT_NAME { get; set; }

        [Column("TARIF")]
        [DisplayName("Тариф")]
        [Category("Информация об оплате")]
        public string TARIF { get; set; }

        [Column("SUM_M")]
        [DisplayName("Сумма, выставленная к оплате")]
        [Category("Информация об оплате")]
        public string SUM_M { get; set; }

        [Column("SUM_P")]
        [DisplayName("Сумма оплаты по счёту")]
        [Category("Информация об оплате")]
        public string SUM_P { get; set; }

        [Column("NPOLIS")]
        [DisplayName("Номер документа, подтверждающего факт страхования по ОМС")]
        [Category("Пациент")]
        public string NPOLIS { get; set; }

        [Column("SNILS")]
        [Category("Пациент")]
        [DisplayName("СНИЛС пациента или представителя")]
        public string SNILS { get; set; }

        [Column("PR_NOV")]
        [DisplayName("Признак исправленной записи")]
        [Category("Информация о случае")]
        [Browsable(false)]
        public string PR_NOV { get; set; }

        [Column("AGE_CATEGORY")]
        [DisplayName("Возрастная категория")]
        [Category("Пациент")]
        public string AGE_CATEGORY { get; set; }

        [Column("CODE_USL_NAME")]
        [DisplayName("Наименование услуги")]
        [Category("Информация о случае")]
        public string CODE_USL_NAME { get; set; }

        [Column("RSLT_D_NAME")]
        [DisplayName("Результат диспансеризации")]
        [Category("Информация о случае")]
        public string RSLT_D_NAME { get; set; }

        [Column("Фамилия пациента")]
        [DisplayName("Фамилия пациента")]
        [Category("Пациент")]
        [Browsable(false)]
        public string FamPac { get; set; }

        [Column("VID_VME")]
        [Browsable(false)]
        public string VID_VME { get; set; }

        [Column("Koef")]
        [DisplayName("Понижающий коэффициент")]
        [Category("Информация об оплате")]
        public string Koef { get; set; }

        [Column("IT_SL")]
        [DisplayName("Повышающий коэффициент")]
        [Category("Информация об оплате")]
        public string IT_SL { get; set; }

        [Column("ПРАВИЛЬНЫЙ КОЭФФИЦИЕНТ")]
        [DisplayName("Правильный коэффициент")]
        [Category("Результат проверки")]
        public string PravilKoef { get; set; }

        [Column("VID_VME_NAME")]
        [DisplayName("Вид медицинского вмешательства")]
        [Category("Информация о случае")]
        public string VID_VME_NAME { get; set; }

        [Column("ЭКСПЕРТИЗА")]
        [Browsable(false)]
        public string Expertiza { get; set; }

        [Column("ПРИМЕЧАНИЕ ДЛЯ ЭКСПЕРТА")]
        [Browsable(false)]
        public string Note { get; set; }

        [Column("КОД ДЕФЕКТА")]
        [DisplayName("Код дефекта")]
        [Category("Результат проверки")]
        public string CodeDef { get; set; }

        [Column("ПРАВИЛЬНЫЙ ТАРИФ")]
        [DisplayName("Правильный тариф")]
        [Category("Результат проверки")]
        public string PravilTarif { get; set; }

        [Column("КОММЕНТАРИЙ ЭКСПЕРТА")]
        [Browsable(false)]
        public string Comment { get; set; }

        [Column("ВЫВОДЫ")]
        [DisplayName("Выводы")]
        [Category("Результат проверки")]
        public string Vivod { get; set; }

        [Column("РЕКОМЕНДАЦИИ")]
        [DisplayName("Рекомендации")]
        [Category("Результат проверки")]
        public string Recommend { get; set; }

        [Column("Операция")]
        [DisplayName("Операция")]
        [Category("Результат проверки")]
        public string Operation { get; set; }

        [Column("Дата операции",CustomFormat = "dd.MM.yyyy")]
        [DisplayName("Дата операции")]
        [Category("Результат проверки")]
        public DateTime? DateOperac { get; set; }

        [Column("Диагноз клинический заключительный основной:")]
        [DisplayName("Диагноз клинический заключительный основной")]
        [Category("Результат проверки")]
        public string DiagnozKlinZaklOsn { get; set; }

        [Column("осложнение кл.зак.")]
        [DisplayName("Осложнение кл.зак.")]
        [Category("Результат проверки")]
        public string OslognenieKlZak { get; set; }

        [Column("сопутствующий кл.зак.")]
        [DisplayName("Сопутствующий кл.зак.")]
        [Category("Результат проверки")]
        public string SoputsKlZak { get; set; }

        [Column("Диагноз патологоанатомический основной:")]
        [DisplayName("Диагноз патологоанатомический основной")]
        [Category("Результат проверки")]
        public string DiagnozPatolOsn { get; set; }

        [Column("осложнение патол.")]
        [DisplayName("Осложнение патол.")]
        [Category("Результат проверки")]
        public string OslogneniePatol { get; set; }

        [Column("сопутствующий патол.")]
        [DisplayName("Сопутствующий патол.")]
        [Category("Результат проверки")]
        public string SoputsPatol { get; set; }

        [Column("I. СБОР ИНФОРМАЦИИ")]
        [DisplayName("I. СБОР ИНФОРМАЦИИ")]
        [Category("Результат проверки")]
        public string SborInformacii { get; set; }

        [Column("II. ДИАГНОЗ")]
        [DisplayName("II. ДИАГНОЗ")]
        [Category("Результат проверки")]
        public string Diagnoz { get; set; }

        [Column("III. ЛЕЧЕНИЕ")]
        [DisplayName("III. ЛЕЧЕНИЕ")]
        [Category("Результат проверки")] 
        public string Lechenie { get; set; }

        [Column("IV. ПРЕЕМСТВЕННОСТЬ")]
        [DisplayName("IV. ПРЕЕМСТВЕННОСТЬ")]
        [Category("Результат проверки")]
        public string Preemstvennost { get; set; }

        [Column("ЗАКЛЮЧЕНИЕ")]
        [Browsable(false)]
        public string Zakluchenie { get; set; }

        [Column("НАИБОЛЕЕ ЗНАЧИМЫЕ ОШИБКИ")]
        [Browsable(false)]
        public string ZnachOshibki { get; set; }

        [DisplayName("Статус")]
        [Browsable(false)]
        public Enums.Status Status => !string.IsNullOrEmpty(CodeDef) ? Enums.Status.Случай_снят : Enums.Status.Случай_не_снят;
    }
}
