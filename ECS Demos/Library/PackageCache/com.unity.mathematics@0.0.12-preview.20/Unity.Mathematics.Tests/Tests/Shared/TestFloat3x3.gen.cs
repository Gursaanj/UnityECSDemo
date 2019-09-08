// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat3x3
    {
        [TestCompiler]
        public static void float3x3_zero()
        {
            TestUtils.AreEqual(float3x3.zero.c0.x, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c0.y, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c0.z, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c1.x, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c1.y, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c1.z, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c2.x, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c2.y, 0.0f);
            TestUtils.AreEqual(float3x3.zero.c2.z, 0.0f);
        }

        [TestCompiler]
        public static void float3x3_identity()
        {
            TestUtils.AreEqual(float3x3.identity.c0.x, 1.0f);
            TestUtils.AreEqual(float3x3.identity.c0.y, 0.0f);
            TestUtils.AreEqual(float3x3.identity.c0.z, 0.0f);
            TestUtils.AreEqual(float3x3.identity.c1.x, 0.0f);
            TestUtils.AreEqual(float3x3.identity.c1.y, 1.0f);
            TestUtils.AreEqual(float3x3.identity.c1.z, 0.0f);
            TestUtils.AreEqual(float3x3.identity.c2.x, 0.0f);
            TestUtils.AreEqual(float3x3.identity.c2.y, 0.0f);
            TestUtils.AreEqual(float3x3.identity.c2.z, 1.0f);
        }

        [TestCompiler]
        public static void float3x3_operator_equal_wide_wide()
        {
            float3x3 a0 = float3x3(-135.18924f, -49.0941162f, 169.129822f, 240.8053f, 314.7392f, 442.393f, 177.924438f, 335.5334f, 168.15448f);
            float3x3 b0 = float3x3(-220.014648f, 66.98004f, 499.2016f, -371.1131f, 208.448669f, 390.8037f, -72.44382f, 362.97644f, 194.678345f);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x3 a1 = float3x3(350.729553f, 367.178467f, 46.9414673f, 188.76416f, -97.2113953f, -293.320984f, -234.822937f, 417.0337f, 26.3864136f);
            float3x3 b1 = float3x3(471.644836f, -404.044678f, -144.696747f, -494.446655f, -252.970367f, 234.417114f, 398.724f, 260.4287f, 370.144226f);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x3 a2 = float3x3(269.245728f, 29.4741821f, 479.485229f, -237.230957f, -221.9837f, -506.672546f, -22.98944f, 487.260864f, -419.731964f);
            float3x3 b2 = float3x3(89.579834f, -434.816833f, -109.845337f, 336.973022f, -409.154968f, 500.387573f, -174.081818f, 395.101135f, 350.3393f);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x3 a3 = float3x3(337.2033f, 245.043884f, 390.215881f, 84.4129639f, 434.2079f, -68.7284241f, 485.769958f, 413.169739f, -418.2693f);
            float3x3 b3 = float3x3(-243.144592f, -416.397369f, 151.576477f, -18.2243347f, -431.677917f, -468.330963f, 429.495728f, 477.389221f, -433.4254f);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(65.6712f, 404.415527f, -269.730164f, 83.6306152f, 152.9945f, -155.868286f, 314.671265f, 386.365173f, 290.04895f);
            float b0 = (-155.815765f);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x3 a1 = float3x3(-132.6352f, -69.68326f, -191.190765f, 186.845215f, -232.895691f, -319.144043f, -49.70108f, -300.8819f, 333.396851f);
            float b1 = (-65.66748f);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x3 a2 = float3x3(386.3775f, -309.1172f, 141.542358f, -227.323334f, 83.87286f, -410.91687f, 110.501282f, -390.103577f, 36.57434f);
            float b2 = (-296.7019f);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x3 a3 = float3x3(-427.541443f, 175.8117f, -193.47995f, 291.051941f, 423.97168f, -429.8739f, -275.156952f, -56.3323669f, -95.83597f);
            float b3 = (-268.170837f);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_equal_scalar_wide()
        {
            float a0 = (36.38391f);
            float3x3 b0 = float3x3(-400.4892f, -71.2868347f, 156.978088f, -225.238739f, 499.141785f, -211.979919f, 428.311951f, -489.501343f, -5.691559f);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-30.8659363f);
            float3x3 b1 = float3x3(-362.9831f, 184.503174f, -160.470612f, 316.668823f, 390.369263f, 505.1051f, -294.6487f, 443.1991f, 96.5592651f);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-257.012939f);
            float3x3 b2 = float3x3(-245.054962f, 326.464844f, -23.9599f, -168.694885f, 386.2486f, -227.090637f, -336.612427f, 365.108154f, -405.390839f);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-473.995483f);
            float3x3 b3 = float3x3(298.435364f, -149.86322f, 450.0664f, 153.47644f, 56.28778f, 39.3421021f, -350.403717f, -482.717224f, 239.9654f);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_not_equal_wide_wide()
        {
            float3x3 a0 = float3x3(279.994141f, -43.34201f, -465.724731f, 317.466553f, 85.7149658f, 360.8905f, 366.081543f, 154.542847f, 332.4262f);
            float3x3 b0 = float3x3(-460.9121f, -476.009033f, 468.1364f, -341.012543f, -62.65805f, -458.801666f, -457.730225f, -59.5232544f, 3.024231f);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x3 a1 = float3x3(397.11322f, -431.374969f, 489.0108f, 398.4336f, -489.817932f, 171.4049f, -67.82968f, -192.278717f, 227.84082f);
            float3x3 b1 = float3x3(155.812744f, -19.8399048f, -6.01693726f, -406.207916f, -102.420715f, -40.362915f, 452.6754f, 93.25757f, -258.378052f);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x3 a2 = float3x3(62.1381836f, 262.186462f, -404.0531f, 34.449585f, -204.795776f, -285.4118f, -72.20682f, 444.749268f, 238.81781f);
            float3x3 b2 = float3x3(-184.0498f, -379.2353f, -370.687317f, -255.947235f, 29.0557861f, 322.407654f, 415.071716f, -467.726135f, -433.784668f);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x3 a3 = float3x3(365.1801f, -437.9229f, -362.442627f, 445.954346f, -0.417480469f, -506.828369f, 245.477051f, -173.571045f, 390.338562f);
            float3x3 b3 = float3x3(-212.165924f, 474.674927f, 452.483215f, -92.11273f, -385.9221f, 420.2151f, -239.176056f, -99.0791f, 4.476013f);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_not_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(-155.4411f, -19.4266052f, 174.633057f, 507.920715f, 59.177063f, 171.151489f, -58.92328f, -398.176849f, 492.20105f);
            float b0 = (-393.413544f);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x3 a1 = float3x3(-165.241516f, -380.243256f, 501.899048f, -134.345459f, 458.400452f, 46.7709961f, 161.459961f, 261.514221f, -145.6124f);
            float b1 = (270.341f);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x3 a2 = float3x3(-0.449920654f, 202.221008f, 242.664f, 382.677063f, -468.967957f, -497.459473f, -80.93225f, -328.587769f, -506.490326f);
            float b2 = (350.461426f);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x3 a3 = float3x3(449.348145f, 249.181824f, -338.468536f, 229.670654f, -76.5433044f, 317.286072f, 401.939575f, 210.984863f, -147.096313f);
            float b3 = (210.771f);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_not_equal_scalar_wide()
        {
            float a0 = (478.353149f);
            float3x3 b0 = float3x3(459.553223f, 436.453247f, -488.714172f, 392.767944f, -266.736633f, 338.557861f, -338.100128f, -152.314545f, -452.820679f);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (209.439331f);
            float3x3 b1 = float3x3(50.10797f, 372.4344f, -488.0213f, 489.740784f, 270.4001f, -472.846771f, -286.850464f, -384.691864f, 443.423523f);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (358.7472f);
            float3x3 b2 = float3x3(-15.4140625f, -342.179169f, 468.967529f, -130.568085f, 401.785828f, -268.352264f, -239.231018f, 411.386536f, 139.769348f);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (334.522034f);
            float3x3 b3 = float3x3(-223.629242f, -12.4884644f, 113.468872f, -189.652252f, -212.846558f, 306.1256f, -178.330383f, 382.141968f, -340.8656f);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_less_wide_wide()
        {
            float3x3 a0 = float3x3(51.7102661f, -313.85556f, 283.047668f, 235.021912f, 44.07837f, -207.255676f, 3.38293457f, -144.301331f, -69.3696f);
            float3x3 b0 = float3x3(-261.835236f, -19.81073f, -149.25882f, 205.99823f, -306.024384f, 102.121704f, 231.906311f, 179.49884f, 473.2249f);
            bool3x3 r0 = bool3x3(false, true, false, false, false, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x3 a1 = float3x3(-135.667969f, -194.787354f, -33.473877f, -19.67508f, 423.237976f, -71.6983f, -501.886f, 7.64386f, 302.262878f);
            float3x3 b1 = float3x3(15.8916626f, 270.049927f, 490.914f, -185.734131f, 76.4331055f, 97.75232f, 419.300781f, 73.953186f, 481.032349f);
            bool3x3 r1 = bool3x3(true, true, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x3 a2 = float3x3(-140.5505f, -436.5867f, -351.4417f, 364.970825f, 301.8941f, 407.550964f, 269.1078f, 462.98822f, 223.884155f);
            float3x3 b2 = float3x3(7.00744629f, -7.32409668f, -413.075745f, -154.1189f, 449.202881f, 502.014282f, -382.315857f, 251.535156f, 143.17395f);
            bool3x3 r2 = bool3x3(true, true, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x3 a3 = float3x3(-287.18924f, 283.6386f, 511.864319f, -60.4967957f, -234.303467f, -316.1384f, -417.522156f, 441.643433f, -191.950623f);
            float3x3 b3 = float3x3(293.660339f, -292.769562f, -43.2182f, -353.4112f, 458.32605f, -114.556458f, 441.429749f, -113.333679f, 435.622925f);
            bool3x3 r3 = bool3x3(true, false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_less_wide_scalar()
        {
            float3x3 a0 = float3x3(-221.869781f, -121.546478f, -97.5239258f, 479.8811f, 67.11902f, 137.3288f, 282.9666f, 258.2791f, -111.413147f);
            float b0 = (199.0675f);
            bool3x3 r0 = bool3x3(true, true, true, false, true, true, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x3 a1 = float3x3(-288.081116f, -361.6429f, -68.0881958f, 12.7880249f, -66.703064f, -78.76297f, 25.7277222f, 101.37085f, -330.442657f);
            float b1 = (82.6654053f);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x3 a2 = float3x3(-48.9205322f, -8.150085f, 241.2768f, -183.437775f, 423.027161f, -334.622742f, -98.31558f, 300.410156f, 297.925232f);
            float b2 = (359.604431f);
            bool3x3 r2 = bool3x3(true, true, true, true, false, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x3 a3 = float3x3(-492.108154f, 95.78882f, -220.62146f, -455.37558f, 360.291565f, -296.372131f, 272.488342f, 360.207947f, 389.727417f);
            float b3 = (-395.807251f);
            bool3x3 r3 = bool3x3(true, false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_less_scalar_wide()
        {
            float a0 = (-250.484924f);
            float3x3 b0 = float3x3(-377.196533f, -505.147552f, 375.9267f, 110.17395f, -118.097565f, -40.4508972f, -299.744324f, 31.4371338f, -458.904541f);
            bool3x3 r0 = bool3x3(false, false, true, true, true, true, false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (13.6846924f);
            float3x3 b1 = float3x3(-458.5069f, 248.276489f, 389.231445f, 488.745544f, -221.637878f, -424.2672f, 249.059021f, -22.1361389f, -442.247742f);
            bool3x3 r1 = bool3x3(false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-340.857544f);
            float3x3 b2 = float3x3(-95.1117249f, 15.4094238f, 87.29248f, 495.067627f, 316.0185f, -125.568115f, 122.164795f, 96.75537f, -228.906342f);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-143.9527f);
            float3x3 b3 = float3x3(-230.238281f, -327.6126f, 103.39801f, 434.488831f, -157.4502f, 190.572144f, 108.2583f, 132.550781f, -431.515228f);
            bool3x3 r3 = bool3x3(false, false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_greater_wide_wide()
        {
            float3x3 a0 = float3x3(-229.29068f, 505.536621f, -73.80707f, 100.292053f, -419.214783f, -159.559753f, -396.770355f, 127.037415f, 489.1399f);
            float3x3 b0 = float3x3(-445.845032f, -420.035278f, 299.0244f, -13.8809814f, 151.5617f, -163.50943f, -391.096039f, 479.283752f, -77.6748657f);
            bool3x3 r0 = bool3x3(true, true, false, true, false, true, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x3 a1 = float3x3(51.9188843f, 155.384766f, -135.631653f, -425.978149f, -228.430511f, 383.03833f, 136.533569f, 8.602417f, -251.324371f);
            float3x3 b1 = float3x3(-46.584198f, -415.377f, 71.46698f, -206.061035f, 360.8363f, 236.968811f, 14.550354f, 364.735168f, -159.06131f);
            bool3x3 r1 = bool3x3(true, true, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x3 a2 = float3x3(-345.954926f, -170.565918f, -293.2544f, 139.125f, 214.3031f, 238.7699f, 105.535217f, -170.9253f, 26.9802246f);
            float3x3 b2 = float3x3(226.631165f, 182.796021f, 341.839355f, -79.13046f, -247.296814f, 164.589111f, -352.1598f, 9.822632f, 186.721619f);
            bool3x3 r2 = bool3x3(false, false, false, true, true, true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x3 a3 = float3x3(-188.928314f, 201.786621f, -506.057159f, 15.454895f, 115.080688f, -496.971832f, 339.888123f, 372.228333f, 313.2387f);
            float3x3 b3 = float3x3(-325.913635f, -77.93036f, -379.746033f, 251.45575f, -144.183563f, 337.8899f, -249.505554f, -225.9013f, -249.491272f);
            bool3x3 r3 = bool3x3(true, true, false, false, true, false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_greater_wide_scalar()
        {
            float3x3 a0 = float3x3(11.156311f, -411.023224f, 385.885559f, -485.103058f, -491.180023f, 405.175354f, 173.575073f, 69.26929f, 501.306824f);
            float b0 = (-302.816956f);
            bool3x3 r0 = bool3x3(true, false, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x3 a1 = float3x3(-367.027771f, -489.090576f, -172.518158f, -18.1496277f, -236.414948f, -238.8945f, -27.2391357f, 471.779358f, 240.164551f);
            float b1 = (-86.12451f);
            bool3x3 r1 = bool3x3(false, false, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x3 a2 = float3x3(-481.4781f, 33.29474f, -510.228149f, -183.2862f, -386.127655f, -13.6382141f, -7.34790039f, -261.865967f, 52.24951f);
            float b2 = (185.59436f);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x3 a3 = float3x3(16.3232422f, -262.2675f, -458.255981f, -218.866119f, -34.6923523f, 290.573059f, 180.2633f, -482.863953f, 100.7063f);
            float b3 = (-410.5101f);
            bool3x3 r3 = bool3x3(true, true, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_greater_scalar_wide()
        {
            float a0 = (453.546082f);
            float3x3 b0 = float3x3(-226.2044f, -423.465f, 409.405518f, 453.877075f, 87.47571f, 113.795593f, 176.409241f, -140.440033f, -182.48288f);
            bool3x3 r0 = bool3x3(true, true, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (-158.2933f);
            float3x3 b1 = float3x3(-162.685333f, -193.328674f, 230.181274f, -102.58783f, 392.520569f, -177.478668f, -10.2950134f, -24.04895f, 172.448669f);
            bool3x3 r1 = bool3x3(true, true, false, false, false, true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (374.048035f);
            float3x3 b2 = float3x3(-368.99762f, -210.195282f, 149.470215f, -281.343262f, -100.469177f, 304.864441f, -361.524841f, -372.452362f, -33.9095459f);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-69.5952759f);
            float3x3 b3 = float3x3(-460.4324f, -309.341675f, 486.131531f, 471.920959f, 479.361572f, -107.004181f, 331.636536f, -340.840149f, -384.2146f);
            bool3x3 r3 = bool3x3(true, true, false, false, false, true, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_less_equal_wide_wide()
        {
            float3x3 a0 = float3x3(240.090515f, 462.213135f, 293.08252f, -427.870667f, -405.5227f, 204.591919f, 294.6701f, -327.564453f, -456.12326f);
            float3x3 b0 = float3x3(-81.20383f, 493.637451f, -411.4721f, 99.16443f, -295.6677f, -480.462555f, 74.41406f, 260.916138f, 306.173279f);
            bool3x3 r0 = bool3x3(false, true, false, true, true, false, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x3 a1 = float3x3(282.30127f, 421.881165f, -311.71283f, 84.5675049f, 447.244629f, -154.494354f, -424.364746f, 36.68451f, 267.0703f);
            float3x3 b1 = float3x3(139.564819f, -505.752472f, -489.6268f, -280.0326f, 303.1599f, 511.1902f, -104.659729f, 95.14661f, -125.636353f);
            bool3x3 r1 = bool3x3(false, false, false, false, false, true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x3 a2 = float3x3(307.893921f, -351.760132f, -157.360352f, 152.709045f, 372.267151f, 202.368286f, -77.04346f, 438.1848f, 260.282349f);
            float3x3 b2 = float3x3(376.2398f, -415.774719f, -47.48105f, 117.722107f, 469.378357f, -263.042358f, -216.002319f, 66.73425f, 99.21863f);
            bool3x3 r2 = bool3x3(true, false, true, false, true, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x3 a3 = float3x3(386.034058f, -281.491f, -102.930054f, -346.716736f, -258.3412f, -383.302948f, -5.14703369f, 319.34375f, 465.022217f);
            float3x3 b3 = float3x3(233.843018f, 439.839966f, 61.1151123f, -219.030579f, -404.7129f, -202.748352f, -312.476471f, 310.0719f, -320.363037f);
            bool3x3 r3 = bool3x3(false, true, true, true, false, true, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_less_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(309.192444f, 69.67377f, -101.724182f, -315.9724f, -346.011047f, 424.15387f, -410.870056f, -483.902649f, 183.821167f);
            float b0 = (292.924255f);
            bool3x3 r0 = bool3x3(false, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x3 a1 = float3x3(320.4425f, -386.801758f, -182.938812f, 349.250122f, 485.311584f, 373.5691f, 259.1515f, 450.130066f, -128.525543f);
            float b1 = (-257.870056f);
            bool3x3 r1 = bool3x3(false, true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x3 a2 = float3x3(-43.8748779f, -77.6383057f, 479.451843f, -499.516449f, -398.132935f, 402.484863f, 87.91608f, -502.1736f, 125.950806f);
            float b2 = (457.385742f);
            bool3x3 r2 = bool3x3(true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x3 a3 = float3x3(-54.49362f, 97.94293f, 228.021545f, -213.378662f, 42.2608032f, -24.8275757f, -451.0416f, 429.577576f, -308.4343f);
            float b3 = (250.667419f);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_less_equal_scalar_wide()
        {
            float a0 = (-511.152374f);
            float3x3 b0 = float3x3(51.1589966f, 340.443665f, 312.81427f, 354.1925f, 136.396729f, -94.76788f, 288.5443f, 304.042847f, -148.618073f);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (-506.3001f);
            float3x3 b1 = float3x3(27.5812378f, 48.47113f, 104.883484f, -488.685852f, -480.435181f, 421.936646f, 239.721069f, -101.018433f, -283.951477f);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-55.24353f);
            float3x3 b2 = float3x3(-455.80484f, 131.107239f, -461.6988f, -388.482849f, -258.936035f, -225.223541f, -116.019989f, -442.595245f, 297.333374f);
            bool3x3 r2 = bool3x3(false, true, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (36.6872559f);
            float3x3 b3 = float3x3(485.097839f, 344.445679f, 237.592163f, 230.390869f, -413.9848f, -215.901672f, 39.5603638f, 22.947998f, -162.060577f);
            bool3x3 r3 = bool3x3(true, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_greater_equal_wide_wide()
        {
            float3x3 a0 = float3x3(-386.5918f, -157.120789f, 391.015259f, -511.886871f, -5.42202759f, 287.645264f, -122.535187f, 7.48144531f, 152.946411f);
            float3x3 b0 = float3x3(153.443f, 49.8924561f, 78.02582f, 138.813721f, -225.51059f, -339.3561f, -373.302063f, 364.9359f, -322.7154f);
            bool3x3 r0 = bool3x3(false, false, true, false, true, true, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x3 a1 = float3x3(48.9862061f, 57.3381348f, 300.4649f, 349.25708f, 85.7496948f, -230.953308f, 418.711243f, -131.039917f, -126.512207f);
            float3x3 b1 = float3x3(125.47821f, -25.77658f, 297.518921f, 73.22235f, 462.783752f, 393.191345f, -95.0014343f, 381.357056f, 93.03192f);
            bool3x3 r1 = bool3x3(false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x3 a2 = float3x3(-156.818481f, 422.3775f, -413.089325f, 219.442749f, 35.5911255f, 447.181519f, -223.492981f, 302.123f, 459.852722f);
            float3x3 b2 = float3x3(254.253235f, 90.67279f, 348.938171f, 161.337646f, 79.43561f, 420.243469f, 453.684875f, -154.011658f, -97.29007f);
            bool3x3 r2 = bool3x3(false, true, false, true, false, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x3 a3 = float3x3(-347.128021f, 364.9781f, 212.635437f, 504.276062f, -142.232971f, -132.2218f, 303.683777f, 265.210144f, 9.754395f);
            float3x3 b3 = float3x3(151.184753f, 57.36029f, -194.207092f, -462.670624f, 113.3866f, -129.3533f, 8.107788f, 426.449524f, 410.693176f);
            bool3x3 r3 = bool3x3(false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_greater_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(495.4574f, -14.3451233f, -463.4748f, 217.517517f, -246.865723f, -377.6587f, 53.8151245f, -123.332947f, -221.505463f);
            float b0 = (189.205139f);
            bool3x3 r0 = bool3x3(true, false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x3 a1 = float3x3(252.994324f, -395.3633f, 164.772583f, -287.007324f, 355.837036f, 184.195557f, 273.012268f, -418.1424f, 249.3841f);
            float b1 = (-116.440369f);
            bool3x3 r1 = bool3x3(true, false, true, false, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x3 a2 = float3x3(396.392151f, 243.761414f, -335.12146f, -302.0869f, 254.442261f, 179.005066f, 71.1767f, -331.271667f, 307.890564f);
            float b2 = (332.6654f);
            bool3x3 r2 = bool3x3(true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x3 a3 = float3x3(-388.578522f, -219.892578f, -491.681f, 30.99707f, 199.232239f, -74.50003f, -343.386475f, 216.031555f, -420.403137f);
            float b3 = (150.605774f);
            bool3x3 r3 = bool3x3(false, false, false, false, true, false, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_greater_equal_scalar_wide()
        {
            float a0 = (215.435364f);
            float3x3 b0 = float3x3(204.802979f, -101.104034f, -122.055023f, -70.45615f, -239.62027f, -185.992737f, -455.612579f, 276.665833f, 79.39917f);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (416.420532f);
            float3x3 b1 = float3x3(379.2735f, -439.5147f, 67.14099f, -74.56064f, -367.256348f, 494.950745f, -61.2355347f, -429.170258f, -213.824677f);
            bool3x3 r1 = bool3x3(true, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-264.310181f);
            float3x3 b2 = float3x3(243.11377f, -22.38388f, 304.862f, -323.686157f, 67.93805f, 125.303589f, -400.47052f, -283.159637f, -42.31961f);
            bool3x3 r2 = bool3x3(false, false, false, true, false, false, true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-429.510376f);
            float3x3 b3 = float3x3(499.395874f, -289.963074f, -136.008789f, -351.125244f, -381.8183f, 393.3009f, 18.02362f, -169.92392f, -285.884949f);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_add_wide_wide()
        {
            float3x3 a0 = float3x3(465.148376f, 278.9107f, -277.5299f, -65.1972046f, -473.324371f, -4.69555664f, -470.536774f, -109.9501f, -178.701447f);
            float3x3 b0 = float3x3(483.9944f, -204.07666f, -365.673553f, -509.920868f, -270.6975f, 486.763977f, 267.49176f, 251.642517f, 244.495117f);
            float3x3 r0 = float3x3(949.142761f, 74.8340454f, -643.2035f, -575.118042f, -744.021851f, 482.06842f, -203.045013f, 141.692413f, 65.79367f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x3 a1 = float3x3(-420.033783f, 290.711121f, -446.529633f, 491.066467f, -261.1173f, -298.4069f, 502.4286f, 284.5943f, 401.128418f);
            float3x3 b1 = float3x3(-78.67575f, 352.2055f, 82.7791748f, 462.5473f, -405.492f, -428.498322f, -41.87259f, -269.9275f, 75.20447f);
            float3x3 r1 = float3x3(-498.709534f, 642.9166f, -363.750458f, 953.6138f, -666.6093f, -726.9052f, 460.556f, 14.6668091f, 476.3329f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x3 a2 = float3x3(-36.26349f, -102.949158f, 503.198181f, -384.4291f, -45.22821f, -198.67395f, -62.8800049f, -79.5522461f, 413.098267f);
            float3x3 b2 = float3x3(-141.913391f, -222.186768f, 41.3057251f, 148.339478f, -177.233124f, -176.51889f, 492.692444f, 439.043823f, -511.742767f);
            float3x3 r2 = float3x3(-178.17688f, -325.135925f, 544.5039f, -236.08963f, -222.461334f, -375.192841f, 429.812439f, 359.491577f, -98.6445f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x3 a3 = float3x3(-100.877594f, 418.524f, -183.143127f, 407.443726f, 300.486023f, -261.126129f, -309.830353f, 378.363342f, -224.094f);
            float3x3 b3 = float3x3(-399.057129f, -315.868469f, -228.07724f, -171.7052f, 467.17395f, -474.822937f, 311.390747f, 326.8454f, 475.2119f);
            float3x3 r3 = float3x3(-499.934723f, 102.655518f, -411.220367f, 235.738525f, 767.66f, -735.9491f, 1.56039429f, 705.20874f, 251.11792f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_add_wide_scalar()
        {
            float3x3 a0 = float3x3(459.898315f, -447.663361f, -94.43863f, 126.429871f, -36.254364f, -349.6413f, -2.79125977f, -478.4148f, 443.115234f);
            float b0 = (500.997253f);
            float3x3 r0 = float3x3(960.895569f, 53.3338928f, 406.558624f, 627.4271f, 464.7429f, 151.355957f, 498.206f, 22.5824585f, 944.1125f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x3 a1 = float3x3(268.092224f, -471.256073f, -2.664978f, 78.98584f, 202.14801f, 311.725464f, 10.3458252f, -151.244446f, 355.2328f);
            float b1 = (41.3210449f);
            float3x3 r1 = float3x3(309.413269f, -429.935028f, 38.6560669f, 120.306885f, 243.469055f, 353.0465f, 51.66687f, -109.9234f, 396.553833f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x3 a2 = float3x3(-197.800751f, 244.1471f, -181.626556f, -2.45492554f, 300.900635f, -236.491943f, -160.5841f, -172.5422f, -242.9411f);
            float b2 = (255.955261f);
            float3x3 r2 = float3x3(58.15451f, 500.102356f, 74.3287048f, 253.500336f, 556.8559f, 19.4633179f, 95.3711548f, 83.4130554f, 13.01416f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x3 a3 = float3x3(466.344116f, 264.294f, 372.866821f, -198.837769f, -381.930969f, 402.160339f, -117.024841f, 497.373779f, 485.9093f);
            float b3 = (237.987488f);
            float3x3 r3 = float3x3(704.3316f, 502.2815f, 610.8543f, 39.14972f, -143.943481f, 640.1478f, 120.962646f, 735.361267f, 723.8968f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_add_scalar_wide()
        {
            float a0 = (-325.512756f);
            float3x3 b0 = float3x3(-264.088135f, -106.009247f, -355.4473f, -447.3303f, -158.7002f, -199.4837f, 180.318115f, 337.579346f, -37.0550232f);
            float3x3 r0 = float3x3(-589.6009f, -431.522f, -680.9601f, -772.843f, -484.212952f, -524.99646f, -145.194641f, 12.0665894f, -362.56778f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (230.805f);
            float3x3 b1 = float3x3(-140.174347f, 18.02417f, -138.614349f, 26.9041748f, -374.5376f, 154.46759f, 268.38385f, -190.963013f, 188.617249f);
            float3x3 r1 = float3x3(90.6306458f, 248.829163f, 92.19064f, 257.709167f, -143.7326f, 385.272583f, 499.188843f, 39.84198f, 419.422241f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-504.916138f);
            float3x3 b2 = float3x3(20.45404f, 197.945374f, 251.411926f, -421.0904f, 111.445374f, -73.26889f, 480.884583f, 438.05304f, 66.8443f);
            float3x3 r2 = float3x3(-484.4621f, -306.970764f, -253.504211f, -926.006531f, -393.470764f, -578.185059f, -24.0315552f, -66.8631f, -438.071838f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-270.796021f);
            float3x3 b3 = float3x3(-44.02191f, 197.6947f, 19.1139526f, 349.2378f, 366.2345f, -413.4803f, -260.720184f, 77.54236f, 183.9549f);
            float3x3 r3 = float3x3(-314.817932f, -73.10132f, -251.682068f, 78.44177f, 95.43848f, -684.2763f, -531.516235f, -193.253662f, -86.8411255f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_sub_wide_wide()
        {
            float3x3 a0 = float3x3(133.371033f, -131.832123f, -197.293152f, -485.28656f, -337.550323f, 471.6671f, 146.506592f, -130.585052f, 110.7771f);
            float3x3 b0 = float3x3(123.460266f, 359.56012f, -48.2484741f, 478.979065f, 207.158325f, 142.36731f, -125.6055f, -65.29901f, -477.876434f);
            float3x3 r0 = float3x3(9.910767f, -491.392242f, -149.044678f, -964.2656f, -544.7086f, 329.2998f, 272.1121f, -65.28604f, 588.653564f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x3 a1 = float3x3(-235.5416f, 78.87933f, -347.686157f, -470.820557f, -11.45929f, -167.9479f, 330.676758f, -508.350861f, -252.031891f);
            float3x3 b1 = float3x3(164.5f, 428.009583f, 72.62781f, -446.8805f, 432.091431f, -225.554657f, -112.451965f, -210.6128f, -172.925049f);
            float3x3 r1 = float3x3(-400.0416f, -349.130249f, -420.313965f, -23.9400635f, -443.55072f, 57.60675f, 443.128723f, -297.738068f, -79.10684f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x3 a2 = float3x3(-427.9342f, 192.6576f, 168.429321f, 457.308777f, 470.058533f, -299.711884f, -308.939575f, 454.5334f, 26.1069336f);
            float3x3 b2 = float3x3(-80.60748f, 270.046082f, -154.255585f, 148.475769f, 13.6611328f, 70.67108f, -221.325439f, -9.25882f, 288.173828f);
            float3x3 r2 = float3x3(-347.326721f, -77.38849f, 322.6849f, 308.833f, 456.3974f, -370.382965f, -87.6141357f, 463.7922f, -262.0669f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x3 a3 = float3x3(-482.711823f, -40.8535461f, 318.380676f, 475.210815f, 134.926941f, 388.481567f, 138.7182f, -385.5736f, -149.3648f);
            float3x3 b3 = float3x3(217.36145f, 307.540039f, -262.412659f, -405.378021f, 400.004333f, 72.11908f, -154.880585f, -469.659973f, -320.615417f);
            float3x3 r3 = float3x3(-700.073242f, -348.3936f, 580.793335f, 880.588867f, -265.0774f, 316.3625f, 293.5988f, 84.0863647f, 171.25061f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_sub_wide_scalar()
        {
            float3x3 a0 = float3x3(48.9367065f, 410.4516f, -364.4417f, 163.980591f, -460.067322f, 110.919434f, 204.358337f, 180.269714f, -377.9257f);
            float b0 = (-291.5904f);
            float3x3 r0 = float3x3(340.5271f, 702.042f, -72.85132f, 455.570984f, -168.476929f, 402.509827f, 495.94873f, 471.8601f, -86.3353f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x3 a1 = float3x3(-470.262054f, 461.507568f, -246.287262f, 21.6052856f, 246.350708f, -121.427368f, -122.718414f, -122.938721f, 360.15094f);
            float b1 = (400.5349f);
            float3x3 r1 = float3x3(-870.797f, 60.9726563f, -646.822144f, -378.929626f, -154.1842f, -521.9623f, -523.2533f, -523.473633f, -40.3839722f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x3 a2 = float3x3(342.874573f, 164.602356f, 97.0437f, 485.914978f, -205.75766f, 253.443237f, -121.163055f, 187.998413f, -450.820282f);
            float b2 = (18.92981f);
            float3x3 r2 = float3x3(323.944763f, 145.672546f, 78.11389f, 466.985168f, -224.687469f, 234.513428f, -140.092865f, 169.0686f, -469.7501f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x3 a3 = float3x3(-248.073364f, 441.5526f, 449.910583f, 354.886047f, 98.82147f, -189.193237f, 269.074829f, -59.11856f, 363.458374f);
            float b3 = (-26.9960632f);
            float3x3 r3 = float3x3(-221.0773f, 468.548676f, 476.906647f, 381.8821f, 125.817535f, -162.197174f, 296.0709f, -32.1224976f, 390.454437f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_sub_scalar_wide()
        {
            float a0 = (294.5865f);
            float3x3 b0 = float3x3(452.352539f, 256.9898f, -275.159882f, -89.02753f, 488.2284f, -333.2173f, -64.233f, -66.04172f, 341.204956f);
            float3x3 r0 = float3x3(-157.766052f, 37.59668f, 569.746338f, 383.614f, -193.6419f, 627.8038f, 358.8195f, 360.6282f, -46.61847f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-385.775055f);
            float3x3 b1 = float3x3(75.3947754f, 354.943726f, 169.131409f, 88.21661f, 1.73498535f, 122.538025f, -264.945f, -50.83719f, -347.65033f);
            float3x3 r1 = float3x3(-461.16983f, -740.71875f, -554.9065f, -473.991669f, -387.51004f, -508.31308f, -120.830048f, -334.937866f, -38.1247253f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (4.06555176f);
            float3x3 b2 = float3x3(-79.09543f, 354.358337f, -292.4925f, -53.2089844f, -246.3476f, 299.203369f, 432.1847f, -163.88f, 176.742554f);
            float3x3 r2 = float3x3(83.16098f, -350.2928f, 296.558044f, 57.2745361f, 250.413147f, -295.137817f, -428.119141f, 167.945557f, -172.677f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-104.98584f);
            float3x3 b3 = float3x3(-445.797638f, -28.8731689f, -169.588226f, -270.359253f, 68.04761f, -65.53128f, 440.380371f, 427.360657f, -81.47296f);
            float3x3 r3 = float3x3(340.8118f, -76.11267f, 64.60239f, 165.373413f, -173.033447f, -39.45456f, -545.3662f, -532.3465f, -23.5128784f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_mul_wide_wide()
        {
            float3x3 a0 = float3x3(-394.780548f, -412.3722f, -25.8745728f, -241.045959f, -93.6759949f, 244.159973f, 494.688477f, 53.5379639f, -239.4964f);
            float3x3 b0 = float3x3(-149.763977f, -345.04538f, -284.334045f, 267.979248f, -326.6485f, -150.689667f, 207.732422f, 366.192871f, 358.880737f);
            float3x3 r0 = float3x3(59123.9063f, 142287.125f, 7357.022f, -64595.3164f, 30599.123f, -36792.3867f, 102762.836f, 19605.22f, -85950.64f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x3 a1 = float3x3(236.675842f, -211.8562f, -216.654816f, 467.9583f, -178.021912f, -386.394257f, -422.4354f, 464.589539f, -251.315674f);
            float3x3 b1 = float3x3(214.853577f, 253.422791f, -307.7138f, 184.47113f, 426.436462f, -144.281433f, 459.4796f, -358.313354f, -201.3652f);
            float3x3 r1 = float3x3(50850.6523f, -53689.19f, 66667.68f, 86324.8f, -75915.03f, 55749.5156f, -194100.453f, -166468.641f, 50606.23f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x3 a2 = float3x3(-104.97879f, -66.93417f, -39.829895f, 401.5656f, 434.146179f, -336.4542f, -83.11417f, 329.960266f, -316.972168f);
            float3x3 b2 = float3x3(254.909973f, 168.520935f, 8.794556f, -194.846466f, -405.362671f, -180.732178f, -189.746918f, -35.5184631f, 120.31665f);
            float3x3 r2 = float3x3(-26760.14f, -11279.81f, -350.286224f, -78243.64f, -175986.656f, 60808.0977f, 15770.6572f, -11719.6816f, -38137.03f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x3 a3 = float3x3(474.937927f, -445.109161f, -301.003723f, 405.687866f, 142.373474f, -416.213074f, -103.279205f, -52.9519043f, -40.82834f);
            float3x3 b3 = float3x3(-136.203339f, 407.3416f, 301.6543f, -155.482391f, -461.394562f, 296.680359f, 341.001831f, -257.0968f, 17.5936279f);
            float3x3 r3 = float3x3(-64688.1328f, -181311.484f, -90799.07f, -63077.32f, -65690.34f, -123482.242f, -35218.4f, 13613.7656f, -718.3186f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_mul_wide_scalar()
        {
            float3x3 a0 = float3x3(328.203f, -290.10672f, 236.995728f, 120.481384f, 357.903137f, 134.867249f, -477.3105f, -438.272919f, -46.729187f);
            float b0 = (192.211182f);
            float3x3 r0 = float3x3(63084.2852f, -55761.7539f, 45553.23f, 23157.87f, 68792.9844f, 25922.9941f, -91744.4141f, -84240.95f, -8981.872f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x3 a1 = float3x3(-238.405f, -48.83484f, 355.30835f, 119.356628f, -196.995819f, 98.23602f, -325.552155f, 53.9373169f, -87.45099f);
            float b1 = (422.08252f);
            float3x3 r1 = float3x3(-100626.586f, -20612.332f, 149969.438f, 50378.3477f, -83148.49f, 41463.707f, -137409.875f, 22765.998f, -36911.5352f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x3 a2 = float3x3(-130.474121f, 126.015015f, 293.361084f, 174.381958f, -327.120056f, 56.62915f, 257.541565f, -475.6087f, -452.6919f);
            float b2 = (-222.594574f);
            float3x3 r2 = float3x3(29042.832f, -28050.2578f, -65300.5859f, -38816.4766f, 72815.15f, -12605.3418f, -57327.3555f, 105867.914f, 100766.758f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x3 a3 = float3x3(-49.22061f, 431.5857f, 180.355164f, -40.9234619f, 279.543518f, 120.014465f, -59.508667f, 319.489868f, -403.523163f);
            float b3 = (141.600952f);
            float3x3 r3 = float3x3(-6969.68555f, 61112.9453f, 25538.4629f, -5794.80127f, 39583.63f, 16994.1621f, -8426.484f, 45240.07f, -57139.2656f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_mul_scalar_wide()
        {
            float a0 = (-464.5347f);
            float3x3 b0 = float3x3(329.360962f, -198.683441f, 184.0794f, 256.016174f, 266.226318f, -97.8947449f, 159.748108f, -351.8222f, 491.801575f);
            float3x3 r0 = float3x3(-152999.6f, 92295.35f, -85511.27f, -118928.4f, -123671.359f, 45475.5039f, -74208.54f, 163433.625f, -228458.891f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (49.90204f);
            float3x3 b1 = float3x3(424.4626f, 160.1181f, -395.9921f, 125.20166f, -265.0158f, 314.656128f, -292.712036f, -37.72989f, 165.362244f);
            float3x3 r1 = float3x3(21181.5488f, 7990.21973f, -19760.8125f, 6247.818f, -13224.8291f, 15701.9824f, -14606.9277f, -1882.79834f, 8251.913f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (356.517761f);
            float3x3 b2 = float3x3(-188.813324f, 504.9157f, 40.5721436f, -206.775116f, -61.60269f, 118.971619f, 53.7483521f, -198.6694f, 96.236084f);
            float3x3 r2 = float3x3(-67315.3047f, 180011.422f, 14464.6895f, -73719f, -21962.4531f, 42415.4961f, 19162.2422f, -70829.17f, 34309.875f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-20.2418823f);
            float3x3 b3 = float3x3(-31.1239624f, 38.89044f, -13.1333008f, 507.871277f, 95.0179443f, 340.7486f, 438.986877f, -227.165955f, 452.573f);
            float3x3 r3 = float3x3(630.007568f, -787.215759f, 265.842743f, -10280.2705f, -1923.342f, -6897.393f, -8885.921f, 4598.2666f, -9160.93f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_div_wide_wide()
        {
            float3x3 a0 = float3x3(246.265747f, -269.85614f, -451.619537f, -7.388489f, -308.205566f, -373.3948f, 360.41864f, 25.8097534f, -274.050476f);
            float3x3 b0 = float3x3(172.119812f, -77.14111f, -325.8354f, -450.608673f, -261.262146f, -122.449493f, -93.2107849f, -442.005219f, 484.362732f);
            float3x3 r0 = float3x3(1.43078089f, 3.49821424f, 1.38603592f, 0.0163966864f, 1.17967939f, 3.04937816f, -3.86670542f, -0.0583924167f, -0.565795958f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x3 a1 = float3x3(127.538574f, -447.671753f, -137.458588f, -136.133179f, 12.4376221f, 228.513f, 356.972351f, -24.7620544f, 411.6684f);
            float3x3 b1 = float3x3(-390.7818f, 402.02533f, 316.6507f, 397.154419f, -303.2622f, -118.591248f, -81.6503f, -84.34686f, -488.419434f);
            float3x3 r1 = float3x3(-0.326367736f, -1.11354113f, -0.434101641f, -0.3427714f, -0.0410127677f, -1.926896f, -4.37196636f, 0.2935741f, -0.8428584f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x3 a2 = float3x3(-204.078888f, 11.3654175f, 82.15228f, 37.3894653f, 394.2658f, -429.912781f, 315.37384f, -122.665985f, 447.526123f);
            float3x3 b2 = float3x3(404.160522f, -136.728851f, -19.8327026f, -102.607239f, 166.116028f, -112.840179f, -218.209686f, 458.517517f, 119.587219f);
            float3x3 r2 = float3x3(-0.504945159f, -0.0831237659f, -4.14226341f, -0.364394039f, 2.37343621f, 3.80992651f, -1.44527888f, -0.267527372f, 3.742257f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x3 a3 = float3x3(-210.4815f, -202.42157f, -453.007935f, 173.72699f, -167.121674f, -106.234528f, 414.312561f, 7.12084961f, 274.073669f);
            float3x3 b3 = float3x3(356.240417f, -74.50687f, -336.773926f, -216.126312f, 322.385681f, 220.2555f, -67.2345f, 2.229187f, -166.210968f);
            float3x3 r3 = float3x3(-0.5908412f, 2.71681762f, 1.34513962f, -0.803821564f, -0.5183905f, -0.482324064f, -6.16220236f, 3.19437075f, -1.64895058f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_div_wide_scalar()
        {
            float3x3 a0 = float3x3(-244.517456f, 69.1123047f, -333.023132f, 257.396851f, 403.2456f, 154.34436f, 131.526611f, -261.8864f, -348.9238f);
            float b0 = (-60.0243835f);
            float3x3 r0 = float3x3(4.07363558f, -1.15140378f, 5.548131f, -4.28820467f, -6.71803f, -2.571361f, -2.19121981f, 4.36300039f, 5.813034f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x3 a1 = float3x3(-275.5387f, 287.6424f, 504.372253f, 491.7871f, -26.6315918f, -253.236664f, 272.895142f, 178.096191f, -460.87558f);
            float b1 = (210.557922f);
            float3x3 r1 = float3x3(-1.30861235f, 1.36609626f, 2.39540863f, 2.335638f, -0.126481071f, -1.20269358f, 1.29605734f, 0.8458299f, -2.18883038f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x3 a2 = float3x3(-502.646027f, -174.690338f, 83.7963257f, 197.042053f, 317.168274f, 403.387146f, 81.6464844f, 60.6068726f, -413.5605f);
            float b2 = (-84.3248f);
            float3x3 r2 = float3x3(5.9608326f, 2.07163668f, -0.99373287f, -2.33670354f, -3.76126933f, -4.783731f, -0.9682381f, -0.7187313f, 4.90437555f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x3 a3 = float3x3(207.341f, 20.7490845f, -68.57712f, 310.702454f, 417.4049f, 147.866211f, 506.658875f, -435.778564f, 210.672913f);
            float b3 = (358.562134f);
            float3x3 r3 = float3x3(0.578256845f, 0.05786747f, -0.191255882f, 0.8665233f, 1.16410756f, 0.412386566f, 1.41302955f, -1.21535015f, 0.587549269f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_div_scalar_wide()
        {
            float a0 = (41.73767f);
            float3x3 b0 = float3x3(-422.676147f, 248.129639f, 449.391357f, 245.858154f, -326.6206f, 163.715088f, 333.6645f, 38.2910767f, -472.979767f);
            float3x3 r0 = float3x3(-0.09874622f, 0.168209136f, 0.0928759947f, 0.169763222f, -0.1277864f, 0.2549409f, 0.125088736f, 1.0900104f, -0.0882440954f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (192.230164f);
            float3x3 b1 = float3x3(-200.296875f, -490.181519f, -211.10257f, -322.852356f, -137.985291f, 84.32971f, 355.063477f, 276.427246f, -382.988037f);
            float3x3 r1 = float3x3(-0.9597262f, -0.3921612f, -0.9106008f, -0.595412f, -1.39312065f, 2.279507f, 0.5413966f, 0.6954096f, -0.501922131f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-488.647156f);
            float3x3 b2 = float3x3(344.846f, 168.85498f, -44.1955872f, 420.55072f, -175.6152f, -9.220581f, -344.194275f, -449.0715f, 117.704895f);
            float3x3 r2 = float3x3(-1.417001f, -2.89388657f, 11.056469f, -1.1619221f, 2.78248787f, 52.995266f, 1.41968417f, 1.08812773f, -4.15146f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-337.0274f);
            float3x3 b3 = float3x3(239.393433f, -389.355164f, 242.716064f, 496.2765f, 91.74579f, -490.492126f, 485.755432f, -317.572266f, -451.6248f);
            float3x3 r3 = float3x3(-1.407839f, 0.865604043f, -1.38856649f, -0.6791122f, -3.67349172f, 0.6871209f, -0.6938212f, 1.06126213f, 0.746255338f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_mod_wide_wide()
        {
            float3x3 a0 = float3x3(-442.309875f, 368.5005f, -1.09390259f, -364.673828f, -197.343933f, -34.0349121f, -101.348572f, 208.318542f, -140.770325f);
            float3x3 b0 = float3x3(-43.2450562f, -144.195862f, -62.6404724f, -336.828247f, -154.61026f, -154.029358f, 487.0462f, -469.8291f, -145.203766f);
            float3x3 r0 = float3x3(-9.859314f, 80.1087646f, -1.09390259f, -27.8455811f, -42.7336731f, -34.0349121f, -101.348572f, 208.318542f, -140.770325f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x3 a1 = float3x3(183.44696f, -463.368378f, 83.83911f, -64.71405f, 295.066833f, 212.25708f, 349.6283f, 119.875916f, -37.8058167f);
            float3x3 b1 = float3x3(-203.384f, -22.52008f, 224.69f, -435.62674f, 12.0955811f, 40.3787842f, 345.784851f, -433.471252f, -355.649963f);
            float3x3 r1 = float3x3(183.44696f, -12.9667664f, 83.83911f, -64.71405f, 4.772888f, 10.3631592f, 3.84344482f, 119.875916f, -37.8058167f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x3 a2 = float3x3(142.41156f, 332.244263f, -464.194275f, -296.147827f, 225.175354f, -212.060272f, 156.985718f, 507.6183f, 270.830444f);
            float3x3 b2 = float3x3(4.015442f, 66.65979f, -221.853638f, -355.056763f, 357.935974f, 71.3753052f, -131.4183f, -473.9876f, 76.2178345f);
            float3x3 r2 = float3x3(1.87109375f, 65.6051f, -20.487f, -296.147827f, 225.175354f, -69.30966f, 25.5674133f, 33.6306763f, 42.17694f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x3 a3 = float3x3(337.7343f, 384.915833f, 432.5182f, 154.292725f, -37.0853271f, 7.76147461f, 238.094727f, 12.8520508f, -100.240662f);
            float3x3 b3 = float3x3(92.2102051f, -368.189575f, -77.46716f, 135.230591f, 274.277283f, 132.180237f, -179.877319f, 51.9685669f, 367.214233f);
            float3x3 r3 = float3x3(61.1037f, 16.7262573f, 45.182373f, 19.0621338f, -37.0853271f, 7.76147461f, 58.2174072f, 12.8520508f, -100.240662f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_mod_wide_scalar()
        {
            float3x3 a0 = float3x3(-433.417f, -5.51412964f, 393.3944f, 299.41156f, -120.80603f, -502.939026f, -450.807678f, 186.094788f, -84.47363f);
            float b0 = (-90.49924f);
            float3x3 r0 = float3x3(-71.4200439f, -5.51412964f, 31.39746f, 27.9138489f, -30.3067932f, -50.44284f, -88.81073f, 5.09631348f, -84.47363f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x3 a1 = float3x3(-318.7815f, -54.60019f, -172.338867f, -429.714661f, 222.361877f, 5.79638672f, 254.5108f, -433.0937f, -203.082611f);
            float b1 = (433.4547f);
            float3x3 r1 = float3x3(-318.7815f, -54.60019f, -172.338867f, -429.714661f, 222.361877f, 5.79638672f, 254.5108f, -433.0937f, -203.082611f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x3 a2 = float3x3(-75.3564148f, -69.4039f, 5.337219f, -279.060425f, 483.5506f, -331.993347f, 336f, 67.8396f, -124.720764f);
            float b2 = (252.289124f);
            float3x3 r2 = float3x3(-75.3564148f, -69.4039f, 5.337219f, -26.7713013f, 231.261475f, -79.70422f, 83.71088f, 67.8396f, -124.720764f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x3 a3 = float3x3(38.1759033f, 405.773621f, -194.761444f, 235.724f, 465.984863f, -304.153168f, -295.520264f, 313.7224f, -232.202637f);
            float b3 = (271.287f);
            float3x3 r3 = float3x3(38.1759033f, 134.486633f, -194.761444f, 235.724f, 194.697876f, -32.86618f, -24.2332764f, 42.4354248f, -232.202637f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_mod_scalar_wide()
        {
            float a0 = (-396.4224f);
            float3x3 b0 = float3x3(-159.140259f, 230.17334f, 14.7793579f, -303.1565f, 399.635f, 206.6947f, 397.0448f, -393.890656f, -372.067078f);
            float3x3 r0 = float3x3(-78.14188f, -166.249054f, -12.1590881f, -93.2659f, -396.4224f, -189.727692f, -396.4224f, -2.53173828f, -24.3553162f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (201.012268f);
            float3x3 b1 = float3x3(-95.566864f, -258.951477f, 106.983582f, 469.323547f, -34.80899f, 184.836548f, 374.79425f, -131.872711f, -120.092865f);
            float3x3 r1 = float3x3(9.87854f, 201.012268f, 94.02869f, 201.012268f, 26.9673157f, 16.17572f, 201.012268f, 69.13956f, 80.9194f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (4.506653f);
            float3x3 b2 = float3x3(-111.401947f, 391.54248f, -218.668884f, 196.377441f, -511.032623f, 499.9535f, -433.523071f, -163.866852f, 177.004028f);
            float3x3 r2 = float3x3(4.506653f, 4.506653f, 4.506653f, 4.506653f, 4.506653f, 4.506653f, 4.506653f, 4.506653f, 4.506653f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (110.650146f);
            float3x3 b3 = float3x3(17.68457f, -95.85297f, -432.440979f, 192.692078f, -268.131775f, 271.075134f, 423.7027f, -413.233246f, 127.956238f);
            float3x3 r3 = float3x3(4.54272461f, 14.79718f, 110.650146f, 110.650146f, 110.650146f, 110.650146f, 110.650146f, 110.650146f, 110.650146f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_plus()
        {
            float3x3 a0 = float3x3(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f, 190.324646f, -350.3086f, -320.518463f);
            float3x3 r0 = float3x3(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f, 190.324646f, -350.3086f, -320.518463f);
            TestUtils.AreEqual(+a0, r0);

            float3x3 a1 = float3x3(102.054382f, -428.7762f, 377.230164f, 234.773926f, 34.28363f, 258.330383f, 465.355957f, 309.59314f, -316.937134f);
            float3x3 r1 = float3x3(102.054382f, -428.7762f, 377.230164f, 234.773926f, 34.28363f, 258.330383f, 465.355957f, 309.59314f, -316.937134f);
            TestUtils.AreEqual(+a1, r1);

            float3x3 a2 = float3x3(-230.052673f, 2.58575439f, 350.2464f, 60.8197632f, -472.4421f, -364.802551f, 239.152344f, 473.803162f, 285.80896f);
            float3x3 r2 = float3x3(-230.052673f, 2.58575439f, 350.2464f, 60.8197632f, -472.4421f, -364.802551f, 239.152344f, 473.803162f, 285.80896f);
            TestUtils.AreEqual(+a2, r2);

            float3x3 a3 = float3x3(-273.2638f, -113.362305f, -351.754883f, -116.536224f, -496.053284f, -330.005341f, -379.674255f, -339.673218f, -29.0835266f);
            float3x3 r3 = float3x3(-273.2638f, -113.362305f, -351.754883f, -116.536224f, -496.053284f, -330.005341f, -379.674255f, -339.673218f, -29.0835266f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_neg()
        {
            float3x3 a0 = float3x3(420.227173f, -196.2575f, -335.426819f, 509.04364f, -33.0144043f, -498.575317f, -495.837952f, -270.859467f, 19.68689f);
            float3x3 r0 = float3x3(-420.227173f, 196.2575f, 335.426819f, -509.04364f, 33.0144043f, 498.575317f, 495.837952f, 270.859467f, -19.68689f);
            TestUtils.AreEqual(-a0, r0);

            float3x3 a1 = float3x3(268.2367f, 223.381287f, -410.392059f, -395.681549f, -349.149475f, -110.9393f, -238.2196f, 292.543518f, 469.2926f);
            float3x3 r1 = float3x3(-268.2367f, -223.381287f, 410.392059f, 395.681549f, 349.149475f, 110.9393f, 238.2196f, -292.543518f, -469.2926f);
            TestUtils.AreEqual(-a1, r1);

            float3x3 a2 = float3x3(48.29071f, 66.1485f, 55.7080078f, 464.541382f, 499.2428f, 175.015015f, 196.387573f, -306.1656f, 149.660034f);
            float3x3 r2 = float3x3(-48.29071f, -66.1485f, -55.7080078f, -464.541382f, -499.2428f, -175.015015f, -196.387573f, 306.1656f, -149.660034f);
            TestUtils.AreEqual(-a2, r2);

            float3x3 a3 = float3x3(320.391724f, 22.0384521f, -159.55426f, 419.822449f, 303.323425f, 363.716736f, 280.887878f, -270.6513f, -201.615753f);
            float3x3 r3 = float3x3(-320.391724f, -22.0384521f, 159.55426f, -419.822449f, -303.323425f, -363.716736f, -280.887878f, 270.6513f, 201.615753f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_prefix_inc()
        {
            float3x3 a0 = float3x3(-99.79556f, 458.741821f, 96.1790161f, -48.55246f, -315.728973f, -299.230164f, -323.614868f, -456.8903f, -76.50766f);
            float3x3 r0 = float3x3(-98.79556f, 459.741821f, 97.1790161f, -47.55246f, -314.728973f, -298.230164f, -322.614868f, -455.8903f, -75.50766f);
            TestUtils.AreEqual(++a0, r0);

            float3x3 a1 = float3x3(-305.584778f, 148.679321f, 363.2849f, -115.559235f, -326.8778f, -179.894653f, 339.8766f, -38.41043f, -153.373688f);
            float3x3 r1 = float3x3(-304.584778f, 149.679321f, 364.2849f, -114.559235f, -325.8778f, -178.894653f, 340.8766f, -37.41043f, -152.373688f);
            TestUtils.AreEqual(++a1, r1);

            float3x3 a2 = float3x3(261.625549f, -396.650238f, 301.3058f, -221.355408f, -429.698151f, -271.2893f, -264.380066f, -377.5592f, 223.232422f);
            float3x3 r2 = float3x3(262.625549f, -395.650238f, 302.3058f, -220.355408f, -428.698151f, -270.2893f, -263.380066f, -376.5592f, 224.232422f);
            TestUtils.AreEqual(++a2, r2);

            float3x3 a3 = float3x3(-71.076355f, 131.283142f, 22.3049316f, -480.760468f, 200.951782f, 117.9541f, 139.525818f, 335.6897f, 162.6615f);
            float3x3 r3 = float3x3(-70.076355f, 132.283142f, 23.3049316f, -479.760468f, 201.951782f, 118.9541f, 140.525818f, 336.6897f, 163.6615f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_postfix_inc()
        {
            float3x3 a0 = float3x3(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f, 271.454651f, 55.7368774f, 153.7503f);
            float3x3 r0 = float3x3(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f, 271.454651f, 55.7368774f, 153.7503f);
            TestUtils.AreEqual(a0++, r0);

            float3x3 a1 = float3x3(-174.173f, 215.110229f, 159.861023f, -333.050446f, 241.4649f, 287.220459f, -170.104645f, -270.652466f, -162.86026f);
            float3x3 r1 = float3x3(-174.173f, 215.110229f, 159.861023f, -333.050446f, 241.4649f, 287.220459f, -170.104645f, -270.652466f, -162.86026f);
            TestUtils.AreEqual(a1++, r1);

            float3x3 a2 = float3x3(454.488831f, 209.522644f, -311.435852f, 69.7314453f, -232.299652f, -341.498535f, 188.006592f, 417.7298f, 25.5656738f);
            float3x3 r2 = float3x3(454.488831f, 209.522644f, -311.435852f, 69.7314453f, -232.299652f, -341.498535f, 188.006592f, 417.7298f, 25.5656738f);
            TestUtils.AreEqual(a2++, r2);

            float3x3 a3 = float3x3(-463.725647f, -310.144958f, -117.398468f, 403.508728f, -111.279541f, 446.607666f, -12.35257f, -232.150116f, 64.57703f);
            float3x3 r3 = float3x3(-463.725647f, -310.144958f, -117.398468f, 403.508728f, -111.279541f, 446.607666f, -12.35257f, -232.150116f, 64.57703f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_prefix_dec()
        {
            float3x3 a0 = float3x3(-416.201233f, -96.63788f, -50.14566f, -207.316437f, 439.479065f, -304.400818f, 337.968933f, 246.088989f, 171.964539f);
            float3x3 r0 = float3x3(-417.201233f, -97.63788f, -51.14566f, -208.316437f, 438.479065f, -305.400818f, 336.968933f, 245.088989f, 170.964539f);
            TestUtils.AreEqual(--a0, r0);

            float3x3 a1 = float3x3(-227.44281f, 326.5078f, 400.7209f, -478.031372f, -326.452972f, -24.5845032f, 112.796875f, -341.9763f, -503.27417f);
            float3x3 r1 = float3x3(-228.44281f, 325.5078f, 399.7209f, -479.031372f, -327.452972f, -25.5845032f, 111.796875f, -342.9763f, -504.27417f);
            TestUtils.AreEqual(--a1, r1);

            float3x3 a2 = float3x3(-79.6352539f, 147.893677f, -15.7086487f, 188.758423f, 307.791931f, -406.667725f, 181.4751f, -188.69223f, -505.2157f);
            float3x3 r2 = float3x3(-80.6352539f, 146.893677f, -16.7086487f, 187.758423f, 306.791931f, -407.667725f, 180.4751f, -189.69223f, -506.2157f);
            TestUtils.AreEqual(--a2, r2);

            float3x3 a3 = float3x3(-372.241943f, 83.76776f, -30.6314087f, -436.906555f, -51.668396f, 345.021545f, 4.73535156f, -68.65332f, 481.4961f);
            float3x3 r3 = float3x3(-373.241943f, 82.76776f, -31.6314087f, -437.906555f, -52.668396f, 344.021545f, 3.73535156f, -69.65332f, 480.4961f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void float3x3_operator_postfix_dec()
        {
            float3x3 a0 = float3x3(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f, -281.1117f, -262.0626f, -182.405731f);
            float3x3 r0 = float3x3(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f, -281.1117f, -262.0626f, -182.405731f);
            TestUtils.AreEqual(a0--, r0);

            float3x3 a1 = float3x3(450.1281f, -332.154968f, -261.0089f, 205.461121f, -230.227783f, -483.066528f, 378.641235f, 487.344849f, -192.177856f);
            float3x3 r1 = float3x3(450.1281f, -332.154968f, -261.0089f, 205.461121f, -230.227783f, -483.066528f, 378.641235f, 487.344849f, -192.177856f);
            TestUtils.AreEqual(a1--, r1);

            float3x3 a2 = float3x3(-357.0542f, 279.424255f, 115.867737f, -20.8232117f, 323.4054f, 379.156128f, 311.299f, 409.222473f, -428.2567f);
            float3x3 r2 = float3x3(-357.0542f, 279.424255f, 115.867737f, -20.8232117f, 323.4054f, 379.156128f, 311.299f, 409.222473f, -428.2567f);
            TestUtils.AreEqual(a2--, r2);

            float3x3 a3 = float3x3(-425.2884f, -258.848358f, -208.985779f, -313.4259f, 178.3125f, 176.78949f, -370.7863f, 64.90387f, 449.637756f);
            float3x3 r3 = float3x3(-425.2884f, -258.848358f, -208.985779f, -313.4259f, 178.3125f, 176.78949f, -370.7863f, 64.90387f, 449.637756f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
