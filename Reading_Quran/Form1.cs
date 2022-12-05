using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Reading_Quran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 1;

        private void goNext(object sender, EventArgs e)
        {
            i++;

            if (i > 604)
            {
                i = 1;
            }

            changeImage(i);
        }

        private void goBack(object sender, EventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 604;
            }

            changeImage(i);
        }

        public void changeImage(int num)
        {

            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources._11;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources._12;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources._13;
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources._14;
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources._15;
                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources._16;
                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources._17;
                    break;
                case 18:
                    pictureBox1.Image = Properties.Resources._18;
                    break;
                case 19:
                    pictureBox1.Image = Properties.Resources._19;
                    break;
                case 20:
                    pictureBox1.Image = Properties.Resources._20;
                    break;
                case 21:
                    pictureBox1.Image = Properties.Resources._21;
                    break;
                case 22:
                    pictureBox1.Image = Properties.Resources._22;
                    break;
                case 23:
                    pictureBox1.Image = Properties.Resources._23;
                    break;
                case 24:
                    pictureBox1.Image = Properties.Resources._24;
                    break;
                case 25:
                    pictureBox1.Image = Properties.Resources._25;
                    break;
                case 26:
                    pictureBox1.Image = Properties.Resources._26;
                    break;
                case 27:
                    pictureBox1.Image = Properties.Resources._27;
                    break;
                case 28:
                    pictureBox1.Image = Properties.Resources._28;
                    break;
                case 29:
                    pictureBox1.Image = Properties.Resources._29;
                    break;
                case 30:
                    pictureBox1.Image = Properties.Resources._30;
                    break;
                case 31:
                    pictureBox1.Image = Properties.Resources._31;
                    break;
                case 32:
                    pictureBox1.Image = Properties.Resources._32;
                    break;
                case 33:
                    pictureBox1.Image = Properties.Resources._33;
                    break;
                case 34:
                    pictureBox1.Image = Properties.Resources._34;
                    break;
                case 35:
                    pictureBox1.Image = Properties.Resources._35;
                    break;
                case 36:
                    pictureBox1.Image = Properties.Resources._36;
                    break;
                case 37:
                    pictureBox1.Image = Properties.Resources._37;
                    break;
                case 38:
                    pictureBox1.Image = Properties.Resources._38;
                    break;
                case 39:
                    pictureBox1.Image = Properties.Resources._39;
                    break;
                case 40:
                    pictureBox1.Image = Properties.Resources._40;
                    break;
                case 41:
                    pictureBox1.Image = Properties.Resources._41;
                    break;
                case 42:
                    pictureBox1.Image = Properties.Resources._42;
                    break;
                case 43:
                    pictureBox1.Image = Properties.Resources._43;
                    break;
                case 44:
                    pictureBox1.Image = Properties.Resources._44;
                    break;
                case 45:
                    pictureBox1.Image = Properties.Resources._45;
                    break;
                case 46:
                    pictureBox1.Image = Properties.Resources._46;
                    break;
                case 47:
                    pictureBox1.Image = Properties.Resources._47;
                    break;
                case 48:
                    pictureBox1.Image = Properties.Resources._48;
                    break;
                case 49:
                    pictureBox1.Image = Properties.Resources._49;
                    break;
                case 50:
                    pictureBox1.Image = Properties.Resources._50;
                    break;
                case 51:
                    pictureBox1.Image = Properties.Resources._51;
                    break;
                case 52:
                    pictureBox1.Image = Properties.Resources._52;
                    break;
                case 53:
                    pictureBox1.Image = Properties.Resources._53;
                    break;
                case 54:
                    pictureBox1.Image = Properties.Resources._54;
                    break;
                case 55:
                    pictureBox1.Image = Properties.Resources._55;
                    break;
                case 56:
                    pictureBox1.Image = Properties.Resources._56;
                    break;
                case 57:
                    pictureBox1.Image = Properties.Resources._57;
                    break;
                case 58:
                    pictureBox1.Image = Properties.Resources._58;
                    break;
                case 59:
                    pictureBox1.Image = Properties.Resources._59;
                    break;
                case 60:
                    pictureBox1.Image = Properties.Resources._60;
                    break;
                case 61:
                    pictureBox1.Image = Properties.Resources._61;
                    break;
                case 62:
                    pictureBox1.Image = Properties.Resources._62;
                    break;
                case 63:
                    pictureBox1.Image = Properties.Resources._63;
                    break;
                case 64:
                    pictureBox1.Image = Properties.Resources._64;
                    break;
                case 65:
                    pictureBox1.Image = Properties.Resources._65;
                    break;
                case 66:
                    pictureBox1.Image = Properties.Resources._66;
                    break;
                case 67:
                    pictureBox1.Image = Properties.Resources._67;
                    break;
                case 68:
                    pictureBox1.Image = Properties.Resources._68;
                    break;
                case 69:
                    pictureBox1.Image = Properties.Resources._69;
                    break;
                case 70:
                    pictureBox1.Image = Properties.Resources._70;
                    break;
                case 71:
                    pictureBox1.Image = Properties.Resources._71;
                    break;
                case 72:
                    pictureBox1.Image = Properties.Resources._72;
                    break;
                case 73:
                    pictureBox1.Image = Properties.Resources._73;
                    break;
                case 74:
                    pictureBox1.Image = Properties.Resources._74;
                    break;
                case 75:
                    pictureBox1.Image = Properties.Resources._75;
                    break;
                case 76:
                    pictureBox1.Image = Properties.Resources._76;
                    break;
                case 77:
                    pictureBox1.Image = Properties.Resources._77;
                    break;
                case 78:
                    pictureBox1.Image = Properties.Resources._78;
                    break;
                case 79:
                    pictureBox1.Image = Properties.Resources._79;
                    break;
                case 80:
                    pictureBox1.Image = Properties.Resources._80;
                    break;
                case 81:
                    pictureBox1.Image = Properties.Resources._81;
                    break;
                case 82:
                    pictureBox1.Image = Properties.Resources._82;
                    break;
                case 83:
                    pictureBox1.Image = Properties.Resources._83;
                    break;
                case 84:
                    pictureBox1.Image = Properties.Resources._84;
                    break;
                case 85:
                    pictureBox1.Image = Properties.Resources._85;
                    break;
                case 86:
                    pictureBox1.Image = Properties.Resources._86;
                    break;
                case 87:
                    pictureBox1.Image = Properties.Resources._87;
                    break;
                case 88:
                    pictureBox1.Image = Properties.Resources._88;
                    break;
                case 89:
                    pictureBox1.Image = Properties.Resources._89;
                    break;
                case 90:
                    pictureBox1.Image = Properties.Resources._90;
                    break;
                case 91:
                    pictureBox1.Image = Properties.Resources._91;
                    break;
                case 92:
                    pictureBox1.Image = Properties.Resources._92;
                    break;
                case 93:
                    pictureBox1.Image = Properties.Resources._93;
                    break;
                case 94:
                    pictureBox1.Image = Properties.Resources._94;
                    break;
                case 95:
                    pictureBox1.Image = Properties.Resources._95;
                    break;
                case 96:
                    pictureBox1.Image = Properties.Resources._96;
                    break;
                case 97:
                    pictureBox1.Image = Properties.Resources._97;
                    break;
                case 98:
                    pictureBox1.Image = Properties.Resources._98;
                    break;
                case 99:
                    pictureBox1.Image = Properties.Resources._99;
                    break;
                case 100:
                    pictureBox1.Image = Properties.Resources._100;
                    break;
                case 101:
                    pictureBox1.Image = Properties.Resources._101;
                    break;
                case 102:
                    pictureBox1.Image = Properties.Resources._102;
                    break;
                case 103:
                    pictureBox1.Image = Properties.Resources._103;
                    break;
                case 104:
                    pictureBox1.Image = Properties.Resources._104;
                    break;
                case 105:
                    pictureBox1.Image = Properties.Resources._105;
                    break;
                case 106:
                    pictureBox1.Image = Properties.Resources._106;
                    break;
                case 107:
                    pictureBox1.Image = Properties.Resources._107;
                    break;
                case 108:
                    pictureBox1.Image = Properties.Resources._108;
                    break;
                case 109:
                    pictureBox1.Image = Properties.Resources._109;
                    break;
                case 110:
                    pictureBox1.Image = Properties.Resources._110;
                    break;
                case 111:
                    pictureBox1.Image = Properties.Resources._111;
                    break;
                case 112:
                    pictureBox1.Image = Properties.Resources._112;
                    break;
                case 113:
                    pictureBox1.Image = Properties.Resources._113;
                    break;
                case 114:
                    pictureBox1.Image = Properties.Resources._114;
                    break;
                case 115:
                    pictureBox1.Image = Properties.Resources._115;
                    break;
                case 116:
                    pictureBox1.Image = Properties.Resources._116;
                    break;
                case 117:
                    pictureBox1.Image = Properties.Resources._117;
                    break;
                case 118:
                    pictureBox1.Image = Properties.Resources._118;
                    break;
                case 119:
                    pictureBox1.Image = Properties.Resources._119;
                    break;
                case 120:
                    pictureBox1.Image = Properties.Resources._120;
                    break;
                case 121:
                    pictureBox1.Image = Properties.Resources._121;
                    break;
                case 122:
                    pictureBox1.Image = Properties.Resources._122;
                    break;
                case 123:
                    pictureBox1.Image = Properties.Resources._123;
                    break;
                case 124:
                    pictureBox1.Image = Properties.Resources._124;
                    break;
                case 125:
                    pictureBox1.Image = Properties.Resources._125;
                    break;
                case 126:
                    pictureBox1.Image = Properties.Resources._126;
                    break;
                case 127:
                    pictureBox1.Image = Properties.Resources._127;
                    break;
                case 128:
                    pictureBox1.Image = Properties.Resources._128;
                    break;
                case 129:
                    pictureBox1.Image = Properties.Resources._129;
                    break;
                case 130:
                    pictureBox1.Image = Properties.Resources._130;
                    break;
                case 131:
                    pictureBox1.Image = Properties.Resources._131;
                    break;
                case 132:
                    pictureBox1.Image = Properties.Resources._132;
                    break;
                case 133:
                    pictureBox1.Image = Properties.Resources._133;
                    break;
                case 134:
                    pictureBox1.Image = Properties.Resources._134;
                    break;
                case 135:
                    pictureBox1.Image = Properties.Resources._135;
                    break;
                case 136:
                    pictureBox1.Image = Properties.Resources._136;
                    break;
                case 137:
                    pictureBox1.Image = Properties.Resources._137;
                    break;
                case 138:
                    pictureBox1.Image = Properties.Resources._138;
                    break;
                case 139:
                    pictureBox1.Image = Properties.Resources._139;
                    break;
                case 140:
                    pictureBox1.Image = Properties.Resources._140;
                    break;
                case 141:
                    pictureBox1.Image = Properties.Resources._141;
                    break;
                case 142:
                    pictureBox1.Image = Properties.Resources._142;
                    break;
                case 143:
                    pictureBox1.Image = Properties.Resources._143;
                    break;
                case 144:
                    pictureBox1.Image = Properties.Resources._144;
                    break;
                case 145:
                    pictureBox1.Image = Properties.Resources._145;
                    break;
                case 146:
                    pictureBox1.Image = Properties.Resources._146;
                    break;
                case 147:
                    pictureBox1.Image = Properties.Resources._147;
                    break;
                case 148:
                    pictureBox1.Image = Properties.Resources._148;
                    break;
                case 149:
                    pictureBox1.Image = Properties.Resources._149;
                    break;
                case 150:
                    pictureBox1.Image = Properties.Resources._150;
                    break;
                case 151:
                    pictureBox1.Image = Properties.Resources._151;
                    break;
                case 152:
                    pictureBox1.Image = Properties.Resources._152;
                    break;
                case 153:
                    pictureBox1.Image = Properties.Resources._153;
                    break;
                case 154:
                    pictureBox1.Image = Properties.Resources._154;
                    break;
                case 155:
                    pictureBox1.Image = Properties.Resources._155;
                    break;
                case 156:
                    pictureBox1.Image = Properties.Resources._156;
                    break;
                case 157:
                    pictureBox1.Image = Properties.Resources._157;
                    break;
                case 158:
                    pictureBox1.Image = Properties.Resources._158;
                    break;
                case 159:
                    pictureBox1.Image = Properties.Resources._159;
                    break;
                case 160:
                    pictureBox1.Image = Properties.Resources._160;
                    break;
                case 161:
                    pictureBox1.Image = Properties.Resources._161;
                    break;
                case 162:
                    pictureBox1.Image = Properties.Resources._162;
                    break;
                case 163:
                    pictureBox1.Image = Properties.Resources._163;
                    break;
                case 164:
                    pictureBox1.Image = Properties.Resources._164;
                    break;
                case 165:
                    pictureBox1.Image = Properties.Resources._165;
                    break;
                case 166:
                    pictureBox1.Image = Properties.Resources._166;
                    break;
                case 167:
                    pictureBox1.Image = Properties.Resources._167;
                    break;
                case 168:
                    pictureBox1.Image = Properties.Resources._168;
                    break;
                case 169:
                    pictureBox1.Image = Properties.Resources._169;
                    break;
                case 170:
                    pictureBox1.Image = Properties.Resources._170;
                    break;
                case 171:
                    pictureBox1.Image = Properties.Resources._171;
                    break;
                case 172:
                    pictureBox1.Image = Properties.Resources._172;
                    break;
                case 173:
                    pictureBox1.Image = Properties.Resources._173;
                    break;
                case 174:
                    pictureBox1.Image = Properties.Resources._174;
                    break;
                case 175:
                    pictureBox1.Image = Properties.Resources._175;
                    break;
                case 176:
                    pictureBox1.Image = Properties.Resources._176;
                    break;
                case 177:
                    pictureBox1.Image = Properties.Resources._177;
                    break;
                case 178:
                    pictureBox1.Image = Properties.Resources._178;
                    break;
                case 179:
                    pictureBox1.Image = Properties.Resources._179;
                    break;
                case 180:
                    pictureBox1.Image = Properties.Resources._180;
                    break;
                case 181:
                    pictureBox1.Image = Properties.Resources._181;
                    break;
                case 182:
                    pictureBox1.Image = Properties.Resources._182;
                    break;
                case 183:
                    pictureBox1.Image = Properties.Resources._183;
                    break;
                case 184:
                    pictureBox1.Image = Properties.Resources._184;
                    break;
                case 185:
                    pictureBox1.Image = Properties.Resources._185;
                    break;
                case 186:
                    pictureBox1.Image = Properties.Resources._186;
                    break;
                case 187:
                    pictureBox1.Image = Properties.Resources._187;
                    break;
                case 188:
                    pictureBox1.Image = Properties.Resources._188;
                    break;
                case 189:
                    pictureBox1.Image = Properties.Resources._189;
                    break;
                case 190:
                    pictureBox1.Image = Properties.Resources._190;
                    break;
                case 191:
                    pictureBox1.Image = Properties.Resources._191;
                    break;
                case 192:
                    pictureBox1.Image = Properties.Resources._192;
                    break;
                case 193:
                    pictureBox1.Image = Properties.Resources._193;
                    break;
                case 194:
                    pictureBox1.Image = Properties.Resources._194;
                    break;
                case 195:
                    pictureBox1.Image = Properties.Resources._195;
                    break;
                case 196:
                    pictureBox1.Image = Properties.Resources._196;
                    break;
                case 197:
                    pictureBox1.Image = Properties.Resources._197;
                    break;
                case 198:
                    pictureBox1.Image = Properties.Resources._198;
                    break;
                case 199:
                    pictureBox1.Image = Properties.Resources._199;
                    break;
                case 200:
                    pictureBox1.Image = Properties.Resources._200;
                    break;
                case 201:
                    pictureBox1.Image = Properties.Resources._201;
                    break;
                case 202:
                    pictureBox1.Image = Properties.Resources._202;
                    break;
                case 203:
                    pictureBox1.Image = Properties.Resources._203;
                    break;
                case 204:
                    pictureBox1.Image = Properties.Resources._204;
                    break;
                case 205:
                    pictureBox1.Image = Properties.Resources._205;
                    break;
                case 206:
                    pictureBox1.Image = Properties.Resources._206;
                    break;
                case 207:
                    pictureBox1.Image = Properties.Resources._207;
                    break;
                case 208:
                    pictureBox1.Image = Properties.Resources._208;
                    break;
                case 209:
                    pictureBox1.Image = Properties.Resources._209;
                    break;
                case 210:
                    pictureBox1.Image = Properties.Resources._210;
                    break;
                case 211:
                    pictureBox1.Image = Properties.Resources._211;
                    break;
                case 212:
                    pictureBox1.Image = Properties.Resources._212;
                    break;
                case 213:
                    pictureBox1.Image = Properties.Resources._213;
                    break;
                case 214:
                    pictureBox1.Image = Properties.Resources._214;
                    break;
                case 215:
                    pictureBox1.Image = Properties.Resources._215;
                    break;
                case 216:
                    pictureBox1.Image = Properties.Resources._216;
                    break;
                case 217:
                    pictureBox1.Image = Properties.Resources._217;
                    break;
                case 218:
                    pictureBox1.Image = Properties.Resources._218;
                    break;
                case 219:
                    pictureBox1.Image = Properties.Resources._219;
                    break;
                case 220:
                    pictureBox1.Image = Properties.Resources._220;
                    break;
                case 221:
                    pictureBox1.Image = Properties.Resources._221;
                    break;
                case 222:
                    pictureBox1.Image = Properties.Resources._222;
                    break;
                case 223:
                    pictureBox1.Image = Properties.Resources._223;
                    break;
                case 224:
                    pictureBox1.Image = Properties.Resources._224;
                    break;
                case 225:
                    pictureBox1.Image = Properties.Resources._225;
                    break;
                case 226:
                    pictureBox1.Image = Properties.Resources._226;
                    break;
                case 227:
                    pictureBox1.Image = Properties.Resources._227;
                    break;
                case 228:
                    pictureBox1.Image = Properties.Resources._228;
                    break;
                case 229:
                    pictureBox1.Image = Properties.Resources._229;
                    break;
                case 230:
                    pictureBox1.Image = Properties.Resources._230;
                    break;
                case 231:
                    pictureBox1.Image = Properties.Resources._231;
                    break;
                case 232:
                    pictureBox1.Image = Properties.Resources._232;
                    break;
                case 233:
                    pictureBox1.Image = Properties.Resources._233;
                    break;
                case 234:
                    pictureBox1.Image = Properties.Resources._234;
                    break;
                case 235:
                    pictureBox1.Image = Properties.Resources._235;
                    break;
                case 236:
                    pictureBox1.Image = Properties.Resources._236;
                    break;
                case 237:
                    pictureBox1.Image = Properties.Resources._237;
                    break;
                case 238:
                    pictureBox1.Image = Properties.Resources._238;
                    break;
                case 239:
                    pictureBox1.Image = Properties.Resources._239;
                    break;
                case 240:
                    pictureBox1.Image = Properties.Resources._240;
                    break;
                case 241:
                    pictureBox1.Image = Properties.Resources._241;
                    break;
                case 242:
                    pictureBox1.Image = Properties.Resources._242;
                    break;
                case 243:
                    pictureBox1.Image = Properties.Resources._243;
                    break;
                case 244:
                    pictureBox1.Image = Properties.Resources._244;
                    break;
                case 245:
                    pictureBox1.Image = Properties.Resources._245;
                    break;
                case 246:
                    pictureBox1.Image = Properties.Resources._246;
                    break;
                case 247:
                    pictureBox1.Image = Properties.Resources._247;
                    break;
                case 248:
                    pictureBox1.Image = Properties.Resources._248;
                    break;
                case 249:
                    pictureBox1.Image = Properties.Resources._249;
                    break;
                case 250:
                    pictureBox1.Image = Properties.Resources._250;
                    break;
                case 251:
                    pictureBox1.Image = Properties.Resources._251;
                    break;
                case 252:
                    pictureBox1.Image = Properties.Resources._252;
                    break;
                case 253:
                    pictureBox1.Image = Properties.Resources._253;
                    break;
                case 254:
                    pictureBox1.Image = Properties.Resources._254;
                    break;
                case 255:
                    pictureBox1.Image = Properties.Resources._255;
                    break;
                case 256:
                    pictureBox1.Image = Properties.Resources._256;
                    break;
                case 257:
                    pictureBox1.Image = Properties.Resources._257;
                    break;
                case 258:
                    pictureBox1.Image = Properties.Resources._258;
                    break;
                case 259:
                    pictureBox1.Image = Properties.Resources._259;
                    break;
                case 260:
                    pictureBox1.Image = Properties.Resources._260;
                    break;
                case 261:
                    pictureBox1.Image = Properties.Resources._261;
                    break;
                case 262:
                    pictureBox1.Image = Properties.Resources._262;
                    break;
                case 263:
                    pictureBox1.Image = Properties.Resources._263;
                    break;
                case 264:
                    pictureBox1.Image = Properties.Resources._264;
                    break;
                case 265:
                    pictureBox1.Image = Properties.Resources._265;
                    break;
                case 266:
                    pictureBox1.Image = Properties.Resources._266;
                    break;
                case 267:
                    pictureBox1.Image = Properties.Resources._267;
                    break;
                case 268:
                    pictureBox1.Image = Properties.Resources._268;
                    break;
                case 269:
                    pictureBox1.Image = Properties.Resources._269;
                    break;
                case 270:
                    pictureBox1.Image = Properties.Resources._270;
                    break;
                case 271:
                    pictureBox1.Image = Properties.Resources._271;
                    break;
                case 272:
                    pictureBox1.Image = Properties.Resources._272;
                    break;
                case 273:
                    pictureBox1.Image = Properties.Resources._273;
                    break;
                case 274:
                    pictureBox1.Image = Properties.Resources._274;
                    break;
                case 275:
                    pictureBox1.Image = Properties.Resources._275;
                    break;
                case 276:
                    pictureBox1.Image = Properties.Resources._276;
                    break;
                case 277:
                    pictureBox1.Image = Properties.Resources._277;
                    break;
                case 278:
                    pictureBox1.Image = Properties.Resources._278;
                    break;
                case 279:
                    pictureBox1.Image = Properties.Resources._279;
                    break;
                case 280:
                    pictureBox1.Image = Properties.Resources._280;
                    break;
                case 281:
                    pictureBox1.Image = Properties.Resources._281;
                    break;
                case 282:
                    pictureBox1.Image = Properties.Resources._282;
                    break;
                case 283:
                    pictureBox1.Image = Properties.Resources._283;
                    break;
                case 284:
                    pictureBox1.Image = Properties.Resources._284;
                    break;
                case 285:
                    pictureBox1.Image = Properties.Resources._285;
                    break;
                case 286:
                    pictureBox1.Image = Properties.Resources._286;
                    break;
                case 287:
                    pictureBox1.Image = Properties.Resources._287;
                    break;
                case 288:
                    pictureBox1.Image = Properties.Resources._288;
                    break;
                case 289:
                    pictureBox1.Image = Properties.Resources._289;
                    break;
                case 290:
                    pictureBox1.Image = Properties.Resources._290;
                    break;
                case 291:
                    pictureBox1.Image = Properties.Resources._291;
                    break;
                case 292:
                    pictureBox1.Image = Properties.Resources._292;
                    break;
                case 293:
                    pictureBox1.Image = Properties.Resources._293;
                    break;
                case 294:
                    pictureBox1.Image = Properties.Resources._294;
                    break;
                case 295:
                    pictureBox1.Image = Properties.Resources._295;
                    break;
                case 296:
                    pictureBox1.Image = Properties.Resources._296;
                    break;
                case 297:
                    pictureBox1.Image = Properties.Resources._297;
                    break;
                case 298:
                    pictureBox1.Image = Properties.Resources._298;
                    break;
                case 299:
                    pictureBox1.Image = Properties.Resources._299;
                    break;
                case 300:
                    pictureBox1.Image = Properties.Resources._300;
                    break;
                case 301:
                    pictureBox1.Image = Properties.Resources._301;
                    break;
                case 302:
                    pictureBox1.Image = Properties.Resources._302;
                    break;
                case 303:
                    pictureBox1.Image = Properties.Resources._303;
                    break;
                case 304:
                    pictureBox1.Image = Properties.Resources._304;
                    break;
                case 305:
                    pictureBox1.Image = Properties.Resources._305;
                    break;
                case 306:
                    pictureBox1.Image = Properties.Resources._306;
                    break;
                case 307:
                    pictureBox1.Image = Properties.Resources._307;
                    break;
                case 308:
                    pictureBox1.Image = Properties.Resources._308;
                    break;
                case 309:
                    pictureBox1.Image = Properties.Resources._309;
                    break;
                case 310:
                    pictureBox1.Image = Properties.Resources._310;
                    break;
                case 311:
                    pictureBox1.Image = Properties.Resources._311;
                    break;
                case 312:
                    pictureBox1.Image = Properties.Resources._312;
                    break;
                case 313:
                    pictureBox1.Image = Properties.Resources._313;
                    break;
                case 314:
                    pictureBox1.Image = Properties.Resources._314;
                    break;
                case 315:
                    pictureBox1.Image = Properties.Resources._315;
                    break;
                case 316:
                    pictureBox1.Image = Properties.Resources._316;
                    break;
                case 317:
                    pictureBox1.Image = Properties.Resources._317;
                    break;
                case 318:
                    pictureBox1.Image = Properties.Resources._318;
                    break;
                case 319:
                    pictureBox1.Image = Properties.Resources._319;
                    break;
                case 320:
                    pictureBox1.Image = Properties.Resources._320;
                    break;
                case 321:
                    pictureBox1.Image = Properties.Resources._321;
                    break;
                case 322:
                    pictureBox1.Image = Properties.Resources._322;
                    break;
                case 323:
                    pictureBox1.Image = Properties.Resources._323;
                    break;
                case 324:
                    pictureBox1.Image = Properties.Resources._324;
                    break;
                case 325:
                    pictureBox1.Image = Properties.Resources._325;
                    break;
                case 326:
                    pictureBox1.Image = Properties.Resources._326;
                    break;
                case 327:
                    pictureBox1.Image = Properties.Resources._327;
                    break;
                case 328:
                    pictureBox1.Image = Properties.Resources._328;
                    break;
                case 329:
                    pictureBox1.Image = Properties.Resources._329;
                    break;
                case 330:
                    pictureBox1.Image = Properties.Resources._330;
                    break;
                case 331:
                    pictureBox1.Image = Properties.Resources._331;
                    break;
                case 332:
                    pictureBox1.Image = Properties.Resources._332;
                    break;
                case 333:
                    pictureBox1.Image = Properties.Resources._333;
                    break;
                case 334:
                    pictureBox1.Image = Properties.Resources._334;
                    break;
                case 335:
                    pictureBox1.Image = Properties.Resources._335;
                    break;
                case 336:
                    pictureBox1.Image = Properties.Resources._336;
                    break;
                case 337:
                    pictureBox1.Image = Properties.Resources._337;
                    break;
                case 338:
                    pictureBox1.Image = Properties.Resources._338;
                    break;
                case 339:
                    pictureBox1.Image = Properties.Resources._339;
                    break;
                case 340:
                    pictureBox1.Image = Properties.Resources._340;
                    break;
                case 341:
                    pictureBox1.Image = Properties.Resources._341;
                    break;
                case 342:
                    pictureBox1.Image = Properties.Resources._342;
                    break;
                case 343:
                    pictureBox1.Image = Properties.Resources._343;
                    break;
                case 344:
                    pictureBox1.Image = Properties.Resources._344;
                    break;
                case 345:
                    pictureBox1.Image = Properties.Resources._345;
                    break;
                case 346:
                    pictureBox1.Image = Properties.Resources._346;
                    break;
                case 347:
                    pictureBox1.Image = Properties.Resources._347;
                    break;
                case 348:
                    pictureBox1.Image = Properties.Resources._348;
                    break;
                case 349:
                    pictureBox1.Image = Properties.Resources._349;
                    break;
                case 350:
                    pictureBox1.Image = Properties.Resources._350;
                    break;
                case 351:
                    pictureBox1.Image = Properties.Resources._351;
                    break;
                case 352:
                    pictureBox1.Image = Properties.Resources._352;
                    break;
                case 353:
                    pictureBox1.Image = Properties.Resources._353;
                    break;
                case 354:
                    pictureBox1.Image = Properties.Resources._354;
                    break;
                case 355:
                    pictureBox1.Image = Properties.Resources._355;
                    break;
                case 356:
                    pictureBox1.Image = Properties.Resources._356;
                    break;
                case 357:
                    pictureBox1.Image = Properties.Resources._357;
                    break;
                case 358:
                    pictureBox1.Image = Properties.Resources._358;
                    break;
                case 359:
                    pictureBox1.Image = Properties.Resources._359;
                    break;
                case 360:
                    pictureBox1.Image = Properties.Resources._360;
                    break;
                case 361:
                    pictureBox1.Image = Properties.Resources._361;
                    break;
                case 362:
                    pictureBox1.Image = Properties.Resources._362;
                    break;
                case 363:
                    pictureBox1.Image = Properties.Resources._363;
                    break;
                case 364:
                    pictureBox1.Image = Properties.Resources._364;
                    break;
                case 365:
                    pictureBox1.Image = Properties.Resources._365;
                    break;
                case 366:
                    pictureBox1.Image = Properties.Resources._366;
                    break;
                case 367:
                    pictureBox1.Image = Properties.Resources._367;
                    break;
                case 368:
                    pictureBox1.Image = Properties.Resources._368;
                    break;
                case 369:
                    pictureBox1.Image = Properties.Resources._369;
                    break;
                case 370:
                    pictureBox1.Image = Properties.Resources._370;
                    break;
                case 371:
                    pictureBox1.Image = Properties.Resources._371;
                    break;
                case 372:
                    pictureBox1.Image = Properties.Resources._372;
                    break;
                case 373:
                    pictureBox1.Image = Properties.Resources._373;
                    break;
                case 374:
                    pictureBox1.Image = Properties.Resources._374;
                    break;
                case 375:
                    pictureBox1.Image = Properties.Resources._375;
                    break;
                case 376:
                    pictureBox1.Image = Properties.Resources._376;
                    break;
                case 377:
                    pictureBox1.Image = Properties.Resources._377;
                    break;
                case 378:
                    pictureBox1.Image = Properties.Resources._378;
                    break;
                case 379:
                    pictureBox1.Image = Properties.Resources._379;
                    break;
                case 380:
                    pictureBox1.Image = Properties.Resources._380;
                    break;
                case 381:
                    pictureBox1.Image = Properties.Resources._381;
                    break;
                case 382:
                    pictureBox1.Image = Properties.Resources._382;
                    break;
                case 383:
                    pictureBox1.Image = Properties.Resources._383;
                    break;
                case 384:
                    pictureBox1.Image = Properties.Resources._384;
                    break;
                case 385:
                    pictureBox1.Image = Properties.Resources._385;
                    break;
                case 386:
                    pictureBox1.Image = Properties.Resources._386;
                    break;
                case 387:
                    pictureBox1.Image = Properties.Resources._387;
                    break;
                case 388:
                    pictureBox1.Image = Properties.Resources._388;
                    break;
                case 389:
                    pictureBox1.Image = Properties.Resources._389;
                    break;
                case 390:
                    pictureBox1.Image = Properties.Resources._390;
                    break;
                case 391:
                    pictureBox1.Image = Properties.Resources._391;
                    break;
                case 392:
                    pictureBox1.Image = Properties.Resources._392;
                    break;
                case 393:
                    pictureBox1.Image = Properties.Resources._393;
                    break;
                case 394:
                    pictureBox1.Image = Properties.Resources._394;
                    break;
                case 395:
                    pictureBox1.Image = Properties.Resources._395;
                    break;
                case 396:
                    pictureBox1.Image = Properties.Resources._396;
                    break;
                case 397:
                    pictureBox1.Image = Properties.Resources._397;
                    break;
                case 398:
                    pictureBox1.Image = Properties.Resources._398;
                    break;
                case 399:
                    pictureBox1.Image = Properties.Resources._399;
                    break;
                case 400:
                    pictureBox1.Image = Properties.Resources._400;
                    break;
                case 401:
                    pictureBox1.Image = Properties.Resources._401;
                    break;
                case 402:
                    pictureBox1.Image = Properties.Resources._402;
                    break;
                case 403:
                    pictureBox1.Image = Properties.Resources._403;
                    break;
                case 404:
                    pictureBox1.Image = Properties.Resources._404;
                    break;
                case 405:
                    pictureBox1.Image = Properties.Resources._405;
                    break;
                case 406:
                    pictureBox1.Image = Properties.Resources._406;
                    break;
                case 407:
                    pictureBox1.Image = Properties.Resources._407;
                    break;
                case 408:
                    pictureBox1.Image = Properties.Resources._408;
                    break;
                case 409:
                    pictureBox1.Image = Properties.Resources._409;
                    break;
                case 410:
                    pictureBox1.Image = Properties.Resources._410;
                    break;
                case 411:
                    pictureBox1.Image = Properties.Resources._411;
                    break;
                case 412:
                    pictureBox1.Image = Properties.Resources._412;
                    break;
                case 413:
                    pictureBox1.Image = Properties.Resources._413;
                    break;
                case 414:
                    pictureBox1.Image = Properties.Resources._414;
                    break;
                case 415:
                    pictureBox1.Image = Properties.Resources._415;
                    break;
                case 416:
                    pictureBox1.Image = Properties.Resources._416;
                    break;
                case 417:
                    pictureBox1.Image = Properties.Resources._417;
                    break;
                case 418:
                    pictureBox1.Image = Properties.Resources._418;
                    break;
                case 419:
                    pictureBox1.Image = Properties.Resources._419;
                    break;
                case 420:
                    pictureBox1.Image = Properties.Resources._420;
                    break;
                case 421:
                    pictureBox1.Image = Properties.Resources._421;
                    break;
                case 422:
                    pictureBox1.Image = Properties.Resources._422;
                    break;
                case 423:
                    pictureBox1.Image = Properties.Resources._423;
                    break;
                case 424:
                    pictureBox1.Image = Properties.Resources._424;
                    break;
                case 425:
                    pictureBox1.Image = Properties.Resources._425;
                    break;
                case 426:
                    pictureBox1.Image = Properties.Resources._426;
                    break;
                case 427:
                    pictureBox1.Image = Properties.Resources._427;
                    break;
                case 428:
                    pictureBox1.Image = Properties.Resources._428;
                    break;
                case 429:
                    pictureBox1.Image = Properties.Resources._429;
                    break;
                case 430:
                    pictureBox1.Image = Properties.Resources._430;
                    break;
                case 431:
                    pictureBox1.Image = Properties.Resources._431;
                    break;
                case 432:
                    pictureBox1.Image = Properties.Resources._432;
                    break;
                case 433:
                    pictureBox1.Image = Properties.Resources._433;
                    break;
                case 434:
                    pictureBox1.Image = Properties.Resources._434;
                    break;
                case 435:
                    pictureBox1.Image = Properties.Resources._435;
                    break;
                case 436:
                    pictureBox1.Image = Properties.Resources._436;
                    break;
                case 437:
                    pictureBox1.Image = Properties.Resources._437;
                    break;
                case 438:
                    pictureBox1.Image = Properties.Resources._438;
                    break;
                case 439:
                    pictureBox1.Image = Properties.Resources._439;
                    break;
                case 440:
                    pictureBox1.Image = Properties.Resources._440;
                    break;
                case 441:
                    pictureBox1.Image = Properties.Resources._441;
                    break;
                case 442:
                    pictureBox1.Image = Properties.Resources._442;
                    break;
                case 443:
                    pictureBox1.Image = Properties.Resources._443;
                    break;
                case 444:
                    pictureBox1.Image = Properties.Resources._444;
                    break;
                case 445:
                    pictureBox1.Image = Properties.Resources._445;
                    break;
                case 446:
                    pictureBox1.Image = Properties.Resources._446;
                    break;
                case 447:
                    pictureBox1.Image = Properties.Resources._447;
                    break;
                case 448:
                    pictureBox1.Image = Properties.Resources._448;
                    break;
                case 449:
                    pictureBox1.Image = Properties.Resources._449;
                    break;
                case 450:
                    pictureBox1.Image = Properties.Resources._450;
                    break;
                case 451:
                    pictureBox1.Image = Properties.Resources._451;
                    break;
                case 452:
                    pictureBox1.Image = Properties.Resources._452;
                    break;
                case 453:
                    pictureBox1.Image = Properties.Resources._453;
                    break;
                case 454:
                    pictureBox1.Image = Properties.Resources._454;
                    break;
                case 455:
                    pictureBox1.Image = Properties.Resources._455;
                    break;
                case 456:
                    pictureBox1.Image = Properties.Resources._456;
                    break;
                case 457:
                    pictureBox1.Image = Properties.Resources._457;
                    break;
                case 458:
                    pictureBox1.Image = Properties.Resources._458;
                    break;
                case 459:
                    pictureBox1.Image = Properties.Resources._459;
                    break;
                case 460:
                    pictureBox1.Image = Properties.Resources._460;
                    break;
                case 461:
                    pictureBox1.Image = Properties.Resources._461;
                    break;
                case 462:
                    pictureBox1.Image = Properties.Resources._462;
                    break;
                case 463:
                    pictureBox1.Image = Properties.Resources._463;
                    break;
                case 464:
                    pictureBox1.Image = Properties.Resources._464;
                    break;
                case 465:
                    pictureBox1.Image = Properties.Resources._465;
                    break;
                case 466:
                    pictureBox1.Image = Properties.Resources._466;
                    break;
                case 467:
                    pictureBox1.Image = Properties.Resources._467;
                    break;
                case 468:
                    pictureBox1.Image = Properties.Resources._468;
                    break;
                case 469:
                    pictureBox1.Image = Properties.Resources._469;
                    break;
                case 470:
                    pictureBox1.Image = Properties.Resources._470;
                    break;
                case 471:
                    pictureBox1.Image = Properties.Resources._471;
                    break;
                case 472:
                    pictureBox1.Image = Properties.Resources._472;
                    break;
                case 473:
                    pictureBox1.Image = Properties.Resources._473;
                    break;
                case 474:
                    pictureBox1.Image = Properties.Resources._474;
                    break;
                case 475:
                    pictureBox1.Image = Properties.Resources._475;
                    break;
                case 476:
                    pictureBox1.Image = Properties.Resources._476;
                    break;
                case 477:
                    pictureBox1.Image = Properties.Resources._477;
                    break;
                case 478:
                    pictureBox1.Image = Properties.Resources._478;
                    break;
                case 479:
                    pictureBox1.Image = Properties.Resources._479;
                    break;
                case 480:
                    pictureBox1.Image = Properties.Resources._480;
                    break;
                case 481:
                    pictureBox1.Image = Properties.Resources._481;
                    break;
                case 482:
                    pictureBox1.Image = Properties.Resources._482;
                    break;
                case 483:
                    pictureBox1.Image = Properties.Resources._483;
                    break;
                case 484:
                    pictureBox1.Image = Properties.Resources._484;
                    break;
                case 485:
                    pictureBox1.Image = Properties.Resources._485;
                    break;
                case 486:
                    pictureBox1.Image = Properties.Resources._486;
                    break;
                case 487:
                    pictureBox1.Image = Properties.Resources._487;
                    break;
                case 488:
                    pictureBox1.Image = Properties.Resources._488;
                    break;
                case 489:
                    pictureBox1.Image = Properties.Resources._489;
                    break;
                case 490:
                    pictureBox1.Image = Properties.Resources._490;
                    break;
                case 491:
                    pictureBox1.Image = Properties.Resources._491;
                    break;
                case 492:
                    pictureBox1.Image = Properties.Resources._492;
                    break;
                case 493:
                    pictureBox1.Image = Properties.Resources._493;
                    break;
                case 494:
                    pictureBox1.Image = Properties.Resources._494;
                    break;
                case 495:
                    pictureBox1.Image = Properties.Resources._495;
                    break;
                case 496:
                    pictureBox1.Image = Properties.Resources._496;
                    break;
                case 497:
                    pictureBox1.Image = Properties.Resources._497;
                    break;
                case 498:
                    pictureBox1.Image = Properties.Resources._498;
                    break;
                case 499:
                    pictureBox1.Image = Properties.Resources._499;
                    break;
                case 500:
                    pictureBox1.Image = Properties.Resources._500;
                    break;
                case 501:
                    pictureBox1.Image = Properties.Resources._501;
                    break;
                case 502:
                    pictureBox1.Image = Properties.Resources._502;
                    break;
                case 503:
                    pictureBox1.Image = Properties.Resources._503;
                    break;
                case 504:
                    pictureBox1.Image = Properties.Resources._504;
                    break;
                case 505:
                    pictureBox1.Image = Properties.Resources._505;
                    break;
                case 506:
                    pictureBox1.Image = Properties.Resources._506;
                    break;
                case 507:
                    pictureBox1.Image = Properties.Resources._507;
                    break;
                case 508:
                    pictureBox1.Image = Properties.Resources._508;
                    break;
                case 509:
                    pictureBox1.Image = Properties.Resources._509;
                    break;
                case 510:
                    pictureBox1.Image = Properties.Resources._510;
                    break;
                case 511:
                    pictureBox1.Image = Properties.Resources._511;
                    break;
                case 512:
                    pictureBox1.Image = Properties.Resources._512;
                    break;
                case 513:
                    pictureBox1.Image = Properties.Resources._513;
                    break;
                case 514:
                    pictureBox1.Image = Properties.Resources._514;
                    break;
                case 515:
                    pictureBox1.Image = Properties.Resources._515;
                    break;
                case 516:
                    pictureBox1.Image = Properties.Resources._516;
                    break;
                case 517:
                    pictureBox1.Image = Properties.Resources._517;
                    break;
                case 518:
                    pictureBox1.Image = Properties.Resources._518;
                    break;
                case 519:
                    pictureBox1.Image = Properties.Resources._519;
                    break;
                case 520:
                    pictureBox1.Image = Properties.Resources._520;
                    break;
                case 521:
                    pictureBox1.Image = Properties.Resources._521;
                    break;
                case 522:
                    pictureBox1.Image = Properties.Resources._522;
                    break;
                case 523:
                    pictureBox1.Image = Properties.Resources._523;
                    break;
                case 524:
                    pictureBox1.Image = Properties.Resources._524;
                    break;
                case 525:
                    pictureBox1.Image = Properties.Resources._525;
                    break;
                case 526:
                    pictureBox1.Image = Properties.Resources._526;
                    break;
                case 527:
                    pictureBox1.Image = Properties.Resources._527;
                    break;
                case 528:
                    pictureBox1.Image = Properties.Resources._528;
                    break;
                case 529:
                    pictureBox1.Image = Properties.Resources._529;
                    break;
                case 530:
                    pictureBox1.Image = Properties.Resources._530;
                    break;
                case 531:
                    pictureBox1.Image = Properties.Resources._531;
                    break;
                case 532:
                    pictureBox1.Image = Properties.Resources._532;
                    break;
                case 533:
                    pictureBox1.Image = Properties.Resources._533;
                    break;
                case 534:
                    pictureBox1.Image = Properties.Resources._534;
                    break;
                case 535:
                    pictureBox1.Image = Properties.Resources._535;
                    break;
                case 536:
                    pictureBox1.Image = Properties.Resources._536;
                    break;
                case 537:
                    pictureBox1.Image = Properties.Resources._537;
                    break;
                case 538:
                    pictureBox1.Image = Properties.Resources._538;
                    break;
                case 539:
                    pictureBox1.Image = Properties.Resources._539;
                    break;
                case 540:
                    pictureBox1.Image = Properties.Resources._540;
                    break;
                case 541:
                    pictureBox1.Image = Properties.Resources._541;
                    break;
                case 542:
                    pictureBox1.Image = Properties.Resources._542;
                    break;
                case 543:
                    pictureBox1.Image = Properties.Resources._543;
                    break;
                case 544:
                    pictureBox1.Image = Properties.Resources._544;
                    break;
                case 545:
                    pictureBox1.Image = Properties.Resources._545;
                    break;
                case 546:
                    pictureBox1.Image = Properties.Resources._546;
                    break;
                case 547:
                    pictureBox1.Image = Properties.Resources._547;
                    break;
                case 548:
                    pictureBox1.Image = Properties.Resources._548;
                    break;
                case 549:
                    pictureBox1.Image = Properties.Resources._549;
                    break;
                case 550:
                    pictureBox1.Image = Properties.Resources._550;
                    break;
                case 551:
                    pictureBox1.Image = Properties.Resources._551;
                    break;
                case 552:
                    pictureBox1.Image = Properties.Resources._552;
                    break;
                case 553:
                    pictureBox1.Image = Properties.Resources._553;
                    break;
                case 554:
                    pictureBox1.Image = Properties.Resources._554;
                    break;
                case 555:
                    pictureBox1.Image = Properties.Resources._555;
                    break;
                case 556:
                    pictureBox1.Image = Properties.Resources._556;
                    break;
                case 557:
                    pictureBox1.Image = Properties.Resources._557;
                    break;
                case 558:
                    pictureBox1.Image = Properties.Resources._558;
                    break;
                case 559:
                    pictureBox1.Image = Properties.Resources._559;
                    break;
                case 560:
                    pictureBox1.Image = Properties.Resources._560;
                    break;
                case 561:
                    pictureBox1.Image = Properties.Resources._561;
                    break;
                case 562:
                    pictureBox1.Image = Properties.Resources._562;
                    break;
                case 563:
                    pictureBox1.Image = Properties.Resources._563;
                    break;
                case 564:
                    pictureBox1.Image = Properties.Resources._564;
                    break;
                case 565:
                    pictureBox1.Image = Properties.Resources._565;
                    break;
                case 566:
                    pictureBox1.Image = Properties.Resources._566;
                    break;
                case 567:
                    pictureBox1.Image = Properties.Resources._567;
                    break;
                case 568:
                    pictureBox1.Image = Properties.Resources._568;
                    break;
                case 569:
                    pictureBox1.Image = Properties.Resources._569;
                    break;
                case 570:
                    pictureBox1.Image = Properties.Resources._570;
                    break;
                case 571:
                    pictureBox1.Image = Properties.Resources._571;
                    break;
                case 572:
                    pictureBox1.Image = Properties.Resources._572;
                    break;
                case 573:
                    pictureBox1.Image = Properties.Resources._573;
                    break;
                case 574:
                    pictureBox1.Image = Properties.Resources._574;
                    break;
                case 575:
                    pictureBox1.Image = Properties.Resources._575;
                    break;
                case 576:
                    pictureBox1.Image = Properties.Resources._576;
                    break;
                case 577:
                    pictureBox1.Image = Properties.Resources._577;
                    break;
                case 578:
                    pictureBox1.Image = Properties.Resources._578;
                    break;
                case 579:
                    pictureBox1.Image = Properties.Resources._579;
                    break;
                case 580:
                    pictureBox1.Image = Properties.Resources._580;
                    break;
                case 581:
                    pictureBox1.Image = Properties.Resources._581;
                    break;
                case 582:
                    pictureBox1.Image = Properties.Resources._582;
                    break;
                case 583:
                    pictureBox1.Image = Properties.Resources._583;
                    break;
                case 584:
                    pictureBox1.Image = Properties.Resources._584;
                    break;
                case 585:
                    pictureBox1.Image = Properties.Resources._585;
                    break;
                case 586:
                    pictureBox1.Image = Properties.Resources._586;
                    break;
                case 587:
                    pictureBox1.Image = Properties.Resources._587;
                    break;
                case 588:
                    pictureBox1.Image = Properties.Resources._588;
                    break;
                case 589:
                    pictureBox1.Image = Properties.Resources._589;
                    break;
                case 590:
                    pictureBox1.Image = Properties.Resources._590;
                    break;
                case 591:
                    pictureBox1.Image = Properties.Resources._591;
                    break;
                case 592:
                    pictureBox1.Image = Properties.Resources._592;
                    break;
                case 593:
                    pictureBox1.Image = Properties.Resources._593;
                    break;
                case 594:
                    pictureBox1.Image = Properties.Resources._594;
                    break;
                case 595:
                    pictureBox1.Image = Properties.Resources._595;
                    break;
                case 596:
                    pictureBox1.Image = Properties.Resources._596;
                    break;
                case 597:
                    pictureBox1.Image = Properties.Resources._597;
                    break;
                case 598:
                    pictureBox1.Image = Properties.Resources._598;
                    break;
                case 599:
                    pictureBox1.Image = Properties.Resources._599;
                    break;
                case 600:
                    pictureBox1.Image = Properties.Resources._600;
                    break;
                case 601:
                    pictureBox1.Image = Properties.Resources._601;
                    break;
                case 602:
                    pictureBox1.Image = Properties.Resources._602;
                    break;
                case 603:
                    pictureBox1.Image = Properties.Resources._603;
                    break;
                case 604:
                    pictureBox1.Image = Properties.Resources._604;
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (form2 uu = new form2())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    uu.frm1 = this;
                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }
}
