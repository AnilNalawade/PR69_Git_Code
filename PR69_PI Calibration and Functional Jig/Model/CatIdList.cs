using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR69_PI_Calibration_and_Functional_Jig.Model
{
    public class CatIdList
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        
        //public string TypesOfOP { get; set; }
        //public bool DUT_Calibration { get; set; }
        //public bool PLCRequired { get; set; }
        //public bool CJC_Support { get; set; }
        public bool IsAnalogInputTestApplicable { get; set; }
        public IList<AnalogInputTests> AnalogIpTests { get; set; }
        public bool IsAnalogOutputTestApplicable { get; set; }
        public IList<AnalogOutputTests> AnalogOpTests { get; set; }
        public bool IsTC_RTDTestApplicable { get; set; }
        public IList<TC_RTDCalibTests> TC_RTDTests { get; set; }
        public bool IsRelayOrSSRTestsApplicable { get; set; }
        public IList<RelayORSSRTests> RelayOrSSRTests { get; set; }
        public bool IsCalibrationConstApplicable { get; set; }
        public IList<CalibrationConstants> CalibrationConstantsTests { get; set; }

        public bool IsCommonTestsApplicable { get; set; }
        public IList<CommonTests> CommonCalibTests { get; set; }

        public IList<string> ListOfGroupSequence { get; set; }

    }
    public class ConfigurationData
    {
        public string DeviceType { get; set; }
        public IList<CatIdList> CatIdLists { get; set; }
    }

    public class ConfigurationDataList
    {
        public IList<ConfigurationData> ConfigurationData { get; set; }
        public IList<CalibrationDelays> CalibrationDelays { get; set; }
        public IList<TolerancesOfPI> TolerancesofPI { get; set; }
        public IList<TolerancesOfPR69> TolerancesOfPR69 { get; set; }
        public string motfilepath { get; set; }

    }

    public class TotalTestsGroup
    {
        public int TestNumber { get; set; }
        public string TestGroup { get; set; }
    }
    
    public class AnalogInputTests
    {
        public bool CALIB_1V_CNT { get; set; }
        public bool CALIB_9V_CNT { get; set; }
        public bool CALIB_4mA_CNT { get; set; }
        public bool CALIB_20mA_CNT { get; set; }
        public bool CALIB_9V_CNT_PI { get; set; }
        public bool CALIB_1V_CNT_PI { get; set; }
        public bool CALIB_20mA_CNT_PI { get; set; }
        public bool CALIB_1mA_CNT_PI { get; set; }
    }

    public class AnalogOutputTests
    {
        public bool SET_DFALT_1MA_CNT { get; set; }   //PI
        public bool SET_DFALT_4MA_CNT { get; set; }   //PR69        
        public bool SET_OBSRVED_1MA_CNT { get; set; } //PI
        public bool SET_OBSRVED_4MA_CNT { get; set; } //PR69        
        public bool SET_DFALT_20MA_CNT { get; set; }
        public bool SET_OBSRVED_20MA_CNT { get; set; }
        public bool CALIBRATE_CURRENT { get; set; }
        public bool SET_12MA_ANLOP { get; set; }
        public bool CHK_ANALOG_OP_VAL { get; set; }
        public bool SLAVE2_OP1_ON { get; set; }     //PR69
        public bool SLAVE2_OP1_OFF { get; set; }    //PR69
        public bool SLAVE2_OP2_ON { get; set; }     //PR69
        public bool SLAVE2_OP2_OFF { get; set; }    //PR69
        public bool SET_DFALT_1V_CNT { get; set; }
        public bool SET_OBSRVED_1V_CNT { get; set; }
        public bool SET_DFALT_10V_CNT { get; set; }
        public bool SET_OBSRVED_10V_CNT { get; set; }
        public bool CALIBRATE_VOLTAGE { get; set; }
        public bool SET_5V_ANLOP { get; set; }
       
    }

    public class TC_RTDCalibTests
    {
        public bool CALIB_1_MV_CNT { get; set; }
        public bool CALIB_47_68_MV_CNT { get; set; } //PR43 (48X48 & 96X96)        
        public bool CALIB_50_MV_CNT { get; set; }        //PR69 (48X48 & 96X96) & PI
        public bool CALC_SLOPE_OFFSET { get; set; }     //PR69 (48X48 & 96X96)
        public bool CALIB_PT100 { get; set; }            //PR69 (48X48 & 96X96) & PI
        public bool CALIB_TC { get; set; }                 //PR69 (48X48 & 96X96)
        public bool CALIB_100_OHM { get; set; }           //PR43 (48X48 & 96X96)
        public bool CALIB_313_71_OHM { get; set; }       //PR43 (48X48 & 96X96)

    }

    public class RelayORSSRTests
    {
        public bool SLAVE1_OP1_ON { get; set; }
        public bool SLAVE1_OP1_OFF { get; set; }
        public bool START_REL_TEST { get; set; }
        public bool DUT_OP1_ON { get; set; }
        public bool DUT_OP1_OFF { get; set; }       
        public bool DUT_OP2_ON { get; set; }
        public bool DUT_OP2_OFF { get; set; }
        public bool DUT_OP3_ON { get; set; }
        public bool DUT_OP3_OFF { get; set; }
        public bool SLAVE1_OP2_ON { get; set; }
        public bool SLAVE1_OP3_ON { get; set; }
        public bool CONVERTOR_OP1_ON { get; set; }
        public bool CONVERTOR_OP2_ON { get; set; }       
        public bool SLAVE1_READ_ADC_CNT_RLY_ON { get; set; }
        public bool SLAVE1_READ_ADC_CNT_RLY_OFF { get; set; }
        public bool CONVERTOR_OP1_OFF { get; set; }
        public bool CONVERTOR_OP2_OFF { get; set; }
        public bool SLAVE1_OP3_OFF { get; set; }
        public bool SLAVE2_OP3_ON { get; set; }
        public bool SLAVE3_OP3_ON { get; set; }        
        public bool SLAVE2_READ_ADC_CNT_RLY_OFF { get; set; }        
        public bool SLAVE2_READ_ADC_CNT_RLY_ON { get; set; }
        
    }

    public class CalibrationConstants
    {
        public bool WRITE_CALIB_CONST { get; set; }
        public bool WRITE_CALIB_CONST_WITH_VREF { get; set; }
    }

    public class CommonTests
    {
        public bool READ_DEVICE_ID { get; set; }
        public bool READ_CALIB_CONST { get; set; }
        public bool SWITCH_SENSOR_RELAY { get; set; }
        public bool SLAVE1_OP1_OFF { get; set; }               //For all PR69(48X48) & PR69(96X96)
        public bool SLAVE1_OP2_OFF { get; set; }                //For all PR69(48X48) & PR69(96X96)
        public bool SLAVE1_OP3_OFF { get; set; }               //For all PR69(48X48) & PR69(96X96)
        public bool SLAVE2_OP1_OFF { get; set; }               //For all PR69(48X48) & PR69(96X96)
        public bool SLAVE2_OP2_OFF { get; set; }             //For all PR69(48X48) & PR69(96X96)
        public bool SLAVE2_OP3_OFF { get; set; }             //For all PR69(48X48) & PR69(96X96)
        public bool SLAVE3_OP3_OFF { get; set; }              //For all PR69(48X48) & PR69(96X96)
        public bool CONVERTOR_OP1_OFF { get; set; }           //For all PR69(48X48) & PR69(96X96)
        public bool CONVERTOR_OP2_OFF { get; set; }           //For all PR69(48X48) & PR69(96X96)
        public bool START_DISP_TEST { get; set; }
        public bool START_KEYPAD_TEST { get; set; }
    }


    public class CalibrationDelays
    {
        public int OnemVOrFiftymVStartModeDelay { get; set; }
        public int OnemVOrFiftymVRunModeDelay { get; set; }
        public int ThreeFiftyOhmStartModeDelay { get; set; }
        public int ThreeFiftyOhmRunModeDelay { get; set; }
        public int FourmAORTwentymAStartModeDelay { get; set; }
        public int FourmAORTwentymARunModeDelay { get; set; }
        public int OneVoltOrNineVoltStartModeDelay { get; set; }
        public int OneVoltOrNineVoltRunModeDelay { get; set; }
        public int AnalogOutputObservedValueDelay { get; set; }
        public int VREFReadDelayStartMode { get; set; }
        public int VREFReadDelayRunMode { get; set; }

    }

    public class TolerancesOfPI
    {
        public int FIVE_VOLT_MIN_PI { get; set; }
        public int FIVE_VOLT_MAX_PI { get; set; }
        public int TWELVE_mA_MIN_PI { get; set; }
        public int TWELVE_mA_MAX_PI { get; set; }
        public int One_VOLT_MAX_PI { get; set; }
        public int One_VOLT_MIN_PI { get; set; }
        public int TEN_VOLT_MAX_PI { get; set; }
        public int TEN_VOLT_MIN_PI { get; set; }
        public int ONE_mAMP_MAX { get; set; }
        public int ONE_mAMP_MIN { get; set; }
        public int TWENTY_mAMP_MAX_PI { get; set; }
        public int TWENTY_mAMP_MIN_PI { get; set; }
    }
    public class TolerancesOfPR69
    {
        public int FIVE_VOLT_MIN { get; set; }
        public int FIVE_VOLT_MAX { get; set; }
        public int TWELVE_mA_MIN { get; set; }
        public int TWELVE_mA_MAX { get; set; }
        public int One_VOLT_MAX { get; set; }
        public int One_VOLT_MIN { get; set; }
        public int TEN_VOLT_MAX { get; set; }
        public int TEN_VOLT_MIN { get; set; }
        public int FOUR_mAMP_MAX { get; set; }
        public int FOUR_mAMP_MIN { get; set; }
        public int TWENTY_mAMP_MAX { get; set; }
        public int TWENTY_mAMP_MIN { get; set; }
    }

    public class TotalConnectedDevices
    {
        public int DeviceNumber { get; set; }
        public IList<TotalTestsGroup> TotalTestsGrouptests { get; set; }
    }

}
