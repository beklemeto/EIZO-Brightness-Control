using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_Brightness
{
    public static class Emerror
    {
        public static bool EmSUCCEEDED(Emerror.EmError Status) => (int)Status >= 0;

        public static bool EmFAILED(Emerror.EmError Status) => (int)Status < 0;

        public enum EmError : uint
        {
            EM_OK = 0,
            EM_EXIST_MORE_DATA = 1,
            EM_RUNNING = 2,
            EM_UNCONFIRMED = 3,
            EM_OK_BUT_DATA_IS_NOT_CORRECTED = 4,
            EM_FAILED = 2147483648, // 0x80000000
            EM_INVALID_ARGUMENT = 2147483649, // 0x80000001
            EM_INVALID_BUFFER = 2147483650, // 0x80000002
            EM_INVALID_BUFFER_SIZE = 2147483651, // 0x80000003
            EM_ALREADY_REGISTERED = 2147483652, // 0x80000004
            EM_NOT_REGISTERED = 2147483653, // 0x80000005
            EM_UNKNOWN = 2147483654, // 0x80000006
            EM_UNSUPPORTED = 2147483655, // 0x80000007
            EM_STALL = 2147483656, // 0x80000008
            EM_UNIMPLEMENTED = 2147483657, // 0x80000009
            EM_OUT_OF_RANGE = 2147483658, // 0x8000000A
            EM_NO_MORE_DATA = 2147483659, // 0x8000000B
            EM_CANCELED = 2147483660, // 0x8000000C
            EM_OUT_OF_DOMAIN = 2147483661, // 0x8000000D
            EM_LONGPROCLOCK_IS_WAIT = 2147483662, // 0x8000000E
            EM_SHORTPROCLOCK_IS_WAIT = 2147483663, // 0x8000000F
            EM_DLL_IS_NOT_FOUND = 2147483664, // 0x80000010
            EM_OVER_LIMIT = 2147483665, // 0x80000011
            EM_ALREADY_USED = 2147483666, // 0x80000012
            EM_TIME_OUT = 2147483667, // 0x80000013
            EM_DISABLED = 2147483668, // 0x80000014
            EM_INVALID_PRECONDITION = 2147483669, // 0x80000015
            EM_UNRESOLVED = 2147483670, // 0x80000016
            EM_RETRY_COUNT_EXCEEDED = 2147483671, // 0x80000017
            EM_ALREADY_CREATED = 2147483672, // 0x80000018
            EM_CANNOT_CREATE_FILE = 2147483673, // 0x80000019
            EM_CONNECTION_ERROR_MONITOR = 2147549185, // 0x80010001
            EM_CONNECTION_ERROR_SENSOR = 2147549186, // 0x80010002
            EM_MEASURE_ERROR = 2147549187, // 0x80010003
            EM_SENSOR_POSITION_ERROR = 2147549188, // 0x80010004
            EM_CALCULATION_ERROR = 2147549189, // 0x80010005
            EM_TERMINATOR = 2147549190, // 0x80010006
        }
    }
}
