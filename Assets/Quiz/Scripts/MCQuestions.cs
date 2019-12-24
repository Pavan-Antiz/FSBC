using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class MCQuestions : MonoBehaviour {

    public static string[] Question;
    public static string[] Choices1;
    public static string[] Choices2;
    public static string[] Choices3;
    public static string[] Choices4;
    public static string[] Answers;
   
    // 1st Quiz 

    public static string[] Question1 = {

        "Which of the following are functions of bearings?",//1
        "A radial bearing supports the load that acts along the axis of the shaft.",//2
        "A_______ bearing supports the load acting along the axis of the shaft",//3
        "Sliding contact bearings, also called plain bearings have no problem of wear",//4
        "In steam and gas turbines, rolling contact bearings are used.",//5
        "Which of the following are true about plasticity?",//6
        "Which of the following is measure of stiffness?",//7
        "Which of the following facts are true for resilience?",//8
        "Modulus of resilience is defined as",//9
        "In gear boxes and small size motors, rolling contact bearings are used.",//10
        "Deep groove ball bearings creates a lot of noise.",//11
        "There is problem of alignment in deep groove ball bearings.",//12
        "Deep groove ball bearing  has  immense rigidity.",//13
        "Cylindrical  load bearing has lower load capacity as compared to deep groove ball bearing.",//14
        "Angular contact bearing can take thrust as well as radial loads",//15
        "In angular contact bearings, ____ bearings are required to take thrust load in both directions.",//16
        "The angular play bearing must be mounted without axial play.",//17
        "Taper rolling supports",//18
        "Which of the following isn’t the property of taper roller?",//19
        "Which of the following cannot take radial load?",//20
        "Static load is defined as the load acting on the bearing when shaft is _____",//21
        "The life of an individual ball bearing is the time period for which it works without any signs of failures.",//22
        "For majority of bearings, actual life is considerably greater than rated life.",//23
        "The dynamic load carrying capacity of a bearing is defined as the radial load in radial bearings that can be carried for a minimum life of 1000 revolutions.",//24
        "A rolling contact bearing is specified as X307. Calculate the bearing diameter.",//25
        "A rolling contact bearing is specified as X307. Determine the series.",//26
        "Thick film lubrication describes a phenomenon where two surfaces are _______ separated.",//27
        "Hydrodynamic bearing is a self-acting bearing.",//28
        "A journal bearing is a ______ contact bearing working on the hydrodynamic lubrication and which supports load in____ direction.",//29
        "Partial bearing is preferred over journal bearing.",//30
        "Temperature rise in partial bearing is ____ than full bearing.",//31
        "A clearance bearing is design accurately to keep the radius of journal and bearing equal.",//32
        "Fitted bearing must be partial bearing",//33
        "Footstep bearing is an axial load bearing.",//34
        "Hydrostatic and hydrodynamic lubrication are the same thing.",//35
        "If we exclude the cost factor, which bearing is preferred?",//36
        "If fluid film pressure is high and surface rigidity is low than mode of lubrication is called as elasto hydrodynamic lubrication.",//37
        "The following is (are) the example(s) of Plain bearing(s).",//38
        "The following type(s) of bearing(s) have no rolling element.",//39
        "Which type of bearing(s) provides a bearing surface for forces acting along axis to the shaft?",//40
        "The type of bearing used in crankshaft is",//41
        "Babbitt is used",//42
        "For Ovens and dryers, the following material is used to make bearings",//43
        "The lubrication in which load of bearing is carried solely by a film of fluid and there is no contact between the two bearings surface is called",//44
        "The lubrication in which load of bearing is carried partly by a film of fluid and partly by direct surface contact is called   ",//45
        "When the load of bearing is carried by direct surface to surface contact is called",//46
        "Hydrostatic bearing usually use ____ as lubricant",//47
        "Hydrostatic bearing enters Hydrodynamic state when the journal is",//48
        "The location of journal is measured by",//49
        "The attitude angle and eccentricity ratio are dependent on the",//50
        "A self-excited vibration of the journal is called",//51
        "Oil whirl in journal bearing can be prevented by",//52
        "In order to prevent oil whirl in journal bearing, there is a shallow relief cut in the center of the bearing over the ____ half of the bearing.",//53
        "Which of the following design eliminate the oil whirl completely?",//54
        "Which of the following bearings carry thrust load in one direction?",//55
        "Which of the following elements is not used as a roller in roller bearings?",//56
        "Load acting on bearing in its plane of rotation is called as __________",//57
        "When the bearing is subjected to large fluctuations of load and heavy impacts, the bearing characteristic number should be _________ the bearing modulus.",//58
        "In hydrodynamic bearings",//59
        "A sliding bearing which operates without any lubricant present, is called",//60
        "The bearings of heavy series have capacity __________ over the medium series.",//61
        "Antifriction bearings are",//62
        "The rolling contact bearings as compared to sliding contact bearings have",//63
        "In standard taper roller bearings, the angle of taper of outer raceway is",//64
        "If a bearing is designated by the number 305, it means that the bearing is of",//65
        "The function of bearing is to ",//66
        "On the basis of direction of load bearing can be classified as ",//67
        "Which of the following is/are the cause of bearing failure? ",//68
        "Which of the following is NOT a component of ball bearing? ",//69
        "The rolling element that can be used in a bearing is/are: ",//70
        "In a radial rolling element bearing, on increasing the size of the rolling elements would ",//71
        "Which of the following statements are true about the seals used in bearings? ",//72
        "Rolling bearings having contact angle lesser than 45 are referred as: ",//73
        "Lundberg palmgren approach is used to estimate:",//74
        "In general which one of the following bearings has the highest coefficient of friction? ",//75
        "Coefficient of friction is higher for needle bearing because ",//76
        "Friction in rolling bearings occurs due to: ",//77
        "What is/are the sources of friction inside the bearing? ",//78
        "On what factors the load capacity of a bearing depends? ",//79
        "What is meant by the preloading of the bearings? ",//80
        "Bearing misalignment is: ",//81
        "The purpose of self-aligning bearing is to ",//82
        "Static load capacity of radial rolling bearings is defined as ",//83
        "he life of the bearing is estimated in ",//84
        "In taper roller bearings the inner and outer rings are known as ",//85
        "Which one of the following is NOT the function of bearing? ",//86
        "Which one of the following is an example of antifriction bearing? ",//87
        "Disadvantage(s) of cylindrical bearing is/are: ",//88
        "Unique advantage(s) of deep groove ball bearing is/are: ",//89
        "Which one of the following bearing is most appropriate for household applications where noise is an important consideration? ",//90
        "Babbitt is called a white metal because of: ",//91
        "Which of the following non-metals can be used as bearing materials? ",//92
        "For heavy radial loads and large shaft diameters which is the most appropriate bearing from the following bearing types? ",//93
        "The two basic patterns of oil grooves used in bearings are: ",//94
        //"",//95
        //"",//96
        //"",//97
        //"",//98
        //"",//99
        //"",//100
        
    };

    public static string[] Choices11 = {

        "Ensure free rotation of shaft with minimum friction",//1
        "True",//2
        "Thrust",//3
        "True",//4
        "True",//5
        "Permanent Deformation",//6
        "Modulus of elasticity",//7
        "Ability of material to absorb energy when deformed elastically",//8
        "Strain energy per unit volume",//9
        "True",//10
        "Yes",//11
        "Yes",//12
        "True",//13
        "True",//14
        "True",//15
        "1",//16
        "Yes",//17
        "Axial loads",//18
        "High rigidity",//19
        "Cylindrical Roller bearing",//20
        "Stationary",//21
        "True",//22
        "True",//23
        "True",//24
        "35mm",//25
        "Extra light series",//26
        "Completely",//27
        "True",//28
        "Sliding, Axial",//29
        "True",//30
        "Lesser",//31
        "Journal radius is kept larger",//32
        "True",//33
        "True",//34
        "True",//35
        "Hydrostatic",//36
        "True",//37
        "Thrust bearing",//38
        "Thrust bearing",//39
        "Thrust bearing",//40
        "Plain bearing",//41
        "Usually to make integral bearings",//42
        "Babbitt",//43
        "Full film condition",//44
        "Full film condition",//45
        "Full film condition",//46
        "Oil",//47
        "Stationery",//48
        "Attitude angle",//49
        "Direction",//50
        "Oil whirl",//51
        "Providing an obstacle to whirling fluid",//52
        "Top",//53
        "Tilting pad",//54
        "Spherical roller thrust bearings",//55
        "Cylindrical",//56
        "axial load",//57
        "10 times",//58
        "The oil film pressure is generated only by the rotation of the journal",//59
        "Zero film bearing",//60
        "20 to 30%",//61
        "Sleeve bearings",//62
        "Low starting and low running friction except at very high speeds",//63
        "5°",//64
        "Medium series whose bore is 5 mm",//65
        "Support load",//66
        "Radial, thrust, conical",//67
        "Sudden rise in bearing load",//68
        "Inner ring.",//69
        "Balls.",//70
        "Increase load capacity of the radial bearing.",//71
        "Seals are made of elastic rubber.",//72
        "Radial bearings.",//73
        "Thrust load rating of bearings.",//74
        "Self-aligning ball bearing.",//75
        "Greater length of rollers and low manufacturing accuracy.",//76
        "Loading and unloading of rolling elements on rings.",//77
        "Friction due to load.",//78
        "Operational speed of the bearing and contact angle.",//79
        "Extra load apart from the rated load capacity.",//80
        "Deformation of rolling elements.",//81
        "Tolerate small amount of misalignment between axes of shaft and bearing.",//82
        "load acting on bearing when rolling elements are not experiencing any load.",//83
        "Number of revolutions at some constant speed.",//84
        "Cone and cup respectively.",//85
        "Ensure free rotation of the shaft with minimum friction.",//86
        "Journal bearing.",//87
        "Cylindrical roller bearing is more rigid than ball bearing.",//88
        "High load carry capacity due to relatively large size of the balls.",//89
        "Deep groove ball bearing.",//90
        "Its whitish appearance.",//91
        "Graphite.",//92
        "Ball bearing.",//93
        "Circumferential groove.",//94
        //"",//95
        //"",//96
        //"",//97
        //"",//98
        //"",//99
        //"",//100
    };

    public static string[] Choices12 = {

        "Holding shaft in a correct position",//1
        "False",//2
        "Radial",//3
        "False",//4
        "False",//5
        "Ability to retain deformation under load or after removal of load",//6
        "Modulus of plasticity",//7
        "Ability to retain deformation under application or after removal of load",//8
        "Strain energy per unit area",//9
        "False",//10
        "They create very less noise",//11
        "No, it is self-aligning",//12
        "No it has point contact  and  hence low rigidity",//13
        "False",//14
        "False",//15
        "4",//16
        "Little tolerance is adjusted",//17
        "Thrust loads",//18
        "Easy dismantling",//19
        "Taper roller bearing",//20
        "Rotating at rpm<10",//21
        "False",//22
        "False",//23
        "False",//24
        "28mm",//25
        "Light series",//26
        "Partially",//27
        "False",//28
        "Rolling, Radial",//29
        "No",//30
        "Greater",//31
        "Journal radius is kept smaller",//32
        "No",//33
        "Thrust load",//34
        "False",//35
        "Hydrodynamic",//36
        "False",//37
        "Linear bearing",//38
        "Linear bearing",//39
        "Journal bearing",//40
        "Roller bearing",//41
        "to not to damage the journal bearing during direct contact",//42
        "Graphite alloy",//43
        "Boundary condition",//44
        "Boundary condition",//45
        "Boundary condition",//46
        "Grease",//47
        "Rotating",//48
        "Pressure angle",//49
        "Speed of rotation",//50
        "Shaft whirl",//51
        "Providing stabilizing load to minimize whirl",//52
        "Bottom",//53
        "Pressure dam",//54
        "Taper roller bearings",//55
        "Taper",//56
        "radial load",//57
        "5 times",//58
        "The oil film is maintained by supplying oil under pressure",//59
        "Boundary lubricated bearing",//60
        "10 to 20%",//61
        "Hydrodynamic bearings",//62
        "Accuracy of shaft alignment",//63
        "8°",//64
        "Medium series whose bore is 25 mm",//65
        "Transmit power",//66
        "Radial, conical, hydrodynamic",//67
        "Inappropriate bearing selection",//68
        "Outer ring.",//69
        "Needle rollers.",//70
        "Decrease load bearing capacity.",//71
        "Seals provide very good grease retainability.",//72
        "Axial bearings.",//73
        "Static load rating of bearings.",//74
        "Cylindrical ball bearing.",//75
        "Rollers cannot be guided well.",//76
        "Deformation of rolling elements.",//77
        "Friction due to sliding.",//78
        "Lubricant behaviour.",//79
        "Initial load on the bearings before the start of the operations.",//80
        "Wear of rolling elements.",//81
        "Tolerate small amount of wear in the rolling elements for continuous operation.",//82
        "load acting on bearing when there is no plastic deformation on rolling elements.",//83
        "Numbers of hours of service at some constant speed.",//84
        "Cup and cone respectively.",//85
        "Support the shaft and hold it in correct position.",//86
        "Plain bearing.",//87
        "Cylindrical roller bearing generates more noise.",//88
        "Ability to take load in radial and axial direction.",//89
        "Self-aligning ball bearings.",//90
        "Its silvery appearance.",//91
        "Plastics(Teflon).",//92
        "Roller bearing.",//93
        "Axial groove.",//94
        //"",//95
        //"",//96
        //"",//97
        //"",//98
        //"",//99
        //"",//100
    };

    public static string[] Choices13 = {

        "Transmit the force of the shaft to the frame",//1
        "",//2
        "Longitudinal",//3
        "",//4
        "",//5
        "Plastic deformation is greater than elastic deformation",//6
        "Resilience",//7
        "Ability of material to absorb energy when deformed plastically",//8
        "Independent of strain energy",//9
        "",//10
        "Depends on the application",//11
        "It aligns itself only in some particular cases",//12
        "It has surface contact",//13
        "",//14
        "",//15
        "2",//16
        "Little tolerance is necessary",//17
        "Both axial and thrust loads",//18
        "Take low radial and heavy loads",//19
        "Thrust ball bearing",//20
        "Rotating at rpm<5",//21
        "",//22
        "",//23
        "",//24
        "21mm",//25
        "Medium series",//26
        "Not",//27
        "",//28
        "Sliding, Radial",//29
        "More friction losses",//30
        "Equal",//31
        "True",//32
        "No lubricating space is required",//33
        "Shear load",//34
        "",//35
        "Both are equally preferred",//36
        "",//37
        "Journal bearing",//38
        "Journal bearing",//39
        "Linear bearing",//40
        "Ball bearing",//41
        "to collect any contaminants in the lubrication",//42
        "Cast iron",//43
        "Dry condition",//44
        "Dry condition",//45
        "Dry condition",//46
        "Nothing",//47
        "Both ‘a’ and ‘b’",//48
        "Wedge angle",//49
        "The load",//50
        "Journal whirl",//51
        "Both ‘a’ and ‘b’",//52
        "Both ‘a’ and ‘b’",//53
        "Stabilizing force",//54
        "Both a. and b.",//55
        "Spherical",//56
        "thrust load",//57
        "15 times",//58
        "Do not require external supply of lubricant",//59
        "Hydrodynamic lubricated bearing",//60
        "30 to 40%",//61
        "Thin lubricated bearings",//62
        "Small overall dimensions",//63
        "15°",//64
        "Light series whose bore is 25 mm",//65
        "Convert rotary to reciprocating motion",//66
        "Aerodynamic, hydrodynamic, dry",//67
        "Improper mounting of bearing",//68
        "Balls and cage.",//69
        "Rollers.",//70
        "Increase or decrease in constraint on outer diameter of outer ring.",//71
        "A seal does not allow dust to enter.",//72
        "Thrust bearings.",//73
        "Wear rate of rolling elements",//74
        "Thrust ball bearing.",//75
        "Rubbing action against rollers.",//76
        "Lubricant shearing inside the bearing.",//77
        "Friction due to churning action of the load.",//78
        "Material properties of rings and rolling elements.",//79
        "Negative clearance between rolling elements and bearing rings.",//80
        "Angle greater than 0.50 between axes of inner and outer rings.",//81
        "Tolerate the plastic deformation in rolling elements and cage.",//82
        "The load acting on the bearing when the shaft is stationary.",//83
        "Both (a) & (b)",//84
        "Cone 1 and Cone 2 respectively.",//85
        "Take up forces that act on shaft and transmit them to frame or foundation.",//86
        "Thrust rolling bearing.",//87
        "Cylindrical roller bearing is not self-aligning.",//88
        "Performance in high speed applications due to less frictional loss.",//89
        "Roller bearings.",//90
        "Its highly reflective surface.",//91
        "Rubber.",//92
        "Self-aligning bearing.",//93
        "Both (a) and (b).",//94
        //"",//95
        //"",//96
        //"",//97
        //"",//98
        //"",//99
        //"",//100
    };

    public static string[] Choices14 ={

        "All of the listed",//1
        "",//2
        "Transversal",//3
        "",//4
        "",//5
        "All of the mentioned",//6
        "Toughness",//7
        "None of the mentioned",//8
        "None of the mentioned",//9
        "",//10
        "No reference frame for comparison is mentioned",//11
        "Can’t be determined",//12
        "It has line contact",//13
        "",//14
        "",//15
        "3",//16
        "Can’t be stated",//17
        "None of the mentioned",//18
        "All are the properties of tapper roller",//19
        "None of the listed",//20
        "None of the listed",//21
        "",//22
        "",//23
        "",//24
        "7mm",//25
        "Heavy series",//26
        "None of the mentioned",//27
        "",//28
        "Rolling, Axial",//29
        "Can’t be determined",//30
        "Undeterminable",//31
        "Can’t be determined",//32
        "Can’t be stated",//33
        "None of the listed",//34
        "",//35
        "Cannot be determined",//36
        "",//37
        "All of the above",//38
        "All of the above",//39
        "None of the above",//40
        "Magnetic bearing",//41
        "All of the above",//42
        "Bronze",//43
        "None of the above",//44
        "None of the above",//45
        "None of the above",//46
        "Any of the above",//47
        "None of the above",//48
        "None of the above",//49
        "All of the above",//50
        "Bearing whirl",//51
        "None of the above",//52
        "None of the above",//53
        "All of the above",//54
        "None of the above",//55
        "None of the above",//56
        "none of the above",//57
        "20 times",//58
        "Grease is used for lubrication",//59
        "Hydrostatic lubricated bearing",//60
        "40 to 50%",//61
        "None of the above",//62
        "All of the above",//63
        "25°",//64
        "Light series whose bore is 5 mm",//65
        "All of the above",//66
        "Rolling, sliding, linear",//67
        "All of above",//68
        "Bush.",//69
        "All of above.",//70
        "Increase or decrease depending on constraint on bore diameter of inner ring.",//71
        "All of above.",//72
        "Contact angle has nothing to do with axial and radial load bearing capacity.",//73
        "Life of rolling element bearings",//74
        "Needle bearing.",//75
        "All of above.",//76
        "All of the above",//77
        "All of the above.",//78
        "All of the above.",//79
        "All of the above.",//80
        "All of the above.",//81
        "Tolerate a small amount of temperature variation.",//82
        "Rolling element and raceway approximately 0.01% of rolling element diameter",//83
        "None of these.",//84
        "Cup 1 and Cup 2 respectively.",//85
        "Reduce centrifugal force of the shaft.",//86
        "Sleeve bearing.",//87
        "Both (b) & (c)",//88
        "All of the above.",//89
        "Needle roller bearing.",//90
        "Its tin content.",//91
        "All of above.",//92
        "Needle roller bearing.",//93
        "Symmetrical groove",//94
        //"",//95
        //"",//96
        //"",//97
        //"",//98
        //"",//99
        //"",//100
    };

    public static string[] Answers1 = {

        "All of the listed",//1
        "False",//2
        "Thrust",//3
        "False",//4
        "False",//5
        "All of the mentioned",//6
        "Modulus of elasticity",//7
        "Ability of material to absorb energy when deformed elastically",//8
        "Strain energy per unit volume",//9
        "True",//10
        "They create very less noise",//11
        "Yes",//12
        "No it has point contact  and  hence low rigidity",//13
        "False",//14
        "True",//15
        "2",//16
        "Yes",//17
        "Both axial and thrust loads",//18
        "Take low radial and heavy loads",//19
        "Thrust ball bearing",//20
        "Stationary",//21
        "False",//22
        "True",//23
        "False",//24
        "35mm",//25
        "Medium series",//26
        "Completely",//27
        "True",//28
        "Sliding, Radial",//29
        "True",//30
        "Lesser",//31
        "Journal radius is kept smaller",//32
        "True",//33
        "Thrust load",//34
        "False",//35
        "Hydrostatic",//36
        "True",//37
        "All of the above",//38
        "All of the above",//39
        "None of the above",//40
        "Plain bearing",//41
        "All of the above",//42
        "Graphite alloy",//43
        "Full film condition",//44
        "Boundary condition",//45
        "Dry condition",//46
        "Oil",//47
        "Rotating",//48
        "Attitude angle",//49
        "All of the above",//50
        "Oil whirl",//51
        "Both ‘a’ and ‘b’",//52
        "Both ‘a’ and ‘b’",//53
        "Pressure dam",//54
        "Both a. and b.",//55
        "None of the above",//56
        "radial load",//57
        "15 times",//58
        "The oil film pressure is generated only by the rotation of the journal",//59
        "Zero film bearing",//60
        "20 to 30%",//61
        "None of the above",//62
        "Small overall dimensions",//63
        "25°",//64
        "Medium series whose bore is 25 mm",//65
        "Support load",//66
        "Radial, thrust, conical",//67
        "All of above",//68
        "Bush.",//69
        "All of above.",//70
        "Increase load capacity of the radial bearing.",//71
        "All of above.",//72
        "Contact angle has nothing to do with axial and radial load bearing capacity.",//73
        "Life of rolling element bearings",//74
        "Needle bearing.",//75
        "All of above.",//76
        "All of the above",//77
        "All of the above.",//78
        "All of the above.",//79
        "All of the above.",//80
        "All of the above.",//81
        "Tolerate a small amount of temperature variation.",//82
        "Rolling element and raceway approximately 0.01% of rolling element diameter",//83
        "None of these.",//84
        "Cup 1 and Cup 2 respectively.",//85
        "Reduce centrifugal force of the shaft.",//86
        "Sleeve bearing.",//87
        "Both (b) & (c)",//88
        "All of the above.",//89
        "Needle roller bearing.",//90
        "Its tin content",//91
        "All of above.",//92
        "Needle roller bearing.",//93
        "Symmetrical groove",//94
        //"",//95
        //"",//96
        //"",//97
        //"",//98
        //"",//99
        //"",//100
    };

}
