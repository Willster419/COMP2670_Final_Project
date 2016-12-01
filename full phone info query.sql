sb.Append("SELECT Phone.phoneID," +//0
            "Manufacturer.name,Phone.name,CPU.frequency," +//1,2,3
            "CPU.numCores,Phone.RAMcapacity,Phone.price," +//4,5,6
            "OS.name,Phone.pictureURL,Phone.internalCapacity," +//7,8,9
            "CPU.cpuID,Manufacturer.manufacturerID,OS.OSID," +//10,11,12
            "Phone.analogAudioJack,Phone.batteryCapacity," +//13,14
            "Phone.chargePortID,ChargePort.name,CPU.model," +//15,16,17
            "CPU.brand,Display.displayID,Display.displayType," +//18,19,20
            "Display.isTouchscreen,Display.heightPixels," +//21,22
            "Display.widthPixels,Display.sizeInches,Display.DPI," +//23,24,25
            "Phone.monthReleased,Phone.yearReleased," +//26,27
            "Phone.expandableCapacity,Phone.hasExternalKeyboard," +//28,29
            "Phone.isUnlocked,Phone.numExternalSpeakers,SIM.numCards," +//30,31,32
            "Phone.physicalHomeButton,SIM.type,Phone.stillAvailable,Phone.weight" +//33,34,35,36
            " from Phone" +
            " inner join Manufacturer on Manufacturer.manufacturerID=Phone.manufacturerID" +
            " inner join OS on OS.OSID=Phone.OSID" +
            " inner join CPU on CPU.CPUID=Phone.CPUID" +
            " inner join ChargePort on ChargePort.chargePortID=Phone.chargePortID" +
            " inner join Display on Display.displayID=Phone.displayID" +
            " inner join SIM on SIM.phoneID=Phone.phoneID" +
            " where Phone.phoneID=");