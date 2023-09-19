using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 校務系統
{
    class ClassCourseChoose
    {
        public Dictionary<string, bool> dicCourseHaveChoosed = new Dictionary<string, bool>();//已選課程清單
        public Dictionary<string, int> dicCoursePoint = new Dictionary<string, int>()//建立課程學分清單
        {
             {"A710120" ,2},
            {"A710520" ,2 },
            //A1外國語文
            {"A110500" ,2},
            {"A110600" ,2},

            //理學院
            //C1數學系
            {"C115621" ,4},
            {"C111211" ,3},
            {"C115720" ,3},
            //C2物理系
            {"C210220",4},
            {"C215820" ,1},
            {"C215621", 3},
            //醫學院
            {"I512520",1 },
            { "I532501",1},
            //C5生科系
            { "C511121",4},
           { "C511220",1},
           /* { },
            { },
            { }*/
        };
        //List<string> CourseHaveChoosed=new List<string>();
        //public string[] CourseHaveChoosed = new string[] { "1" };
        public Dictionary<string, string> dicCourse = new Dictionary<string, string>()
        {
            //A7 通識課程
            {"A710120" ,"基礎國文(二)" },
            {"A710520" ,"基礎國文(古典散文)" },
            //A1外國語文
            {"A110500" ,"基礎學術英文"},
            {"A110600" ,"基礎學術溝通"},

            //理學院
            //C1數學系
            {"C115621" ,"微積分 (二) "},
            {"C111211" ,"線性代數（一）" },
            {"C115720" ,"普通物理學（二）"},
            //C2物理系
            {"C210220","普通物理學（二）"},
            {"C215820" ,"普通物理學實驗（二）"},
            {"C215621", "微積分（二）"},
            //I5醫學院
            {"I512520","習醫之道" },//外系不可選修
            { "I532501","微生物學及免疫學"},
            //C5
            { "C511121","普通生物學"},
            { "C511220","普通生物學生實驗"},
            /*{ },
            { },
            { },
            { }*/
        };
        public Dictionary<string, string> dicCourseAdvice = new Dictionary<string, string>()//建立課程意見清單
        {
             {"A710120" ,""},
            {"A710520" ,""},
            //A1外國語文
            {"A110500" ,""},
            {"A110600" ,""},

            //理學院
            //C1數學系
            {"C115621" ,""},
            {"C111211" ,""},
            {"C115720" ,""},
            //C2物理系
            {"C210220",""},
            {"C215820" ,""},
            {"C215621", ""},
            //醫學院
            {"I512520",""},
            {"I532501","" },
            //C5生科院
            { "C511121",""},
            { "C511220",""},
            /*{ },
            { },
            { },
            { }*/
        };                            //新課程名稱       //新課程代碼
        public void AddNewCourse(string coursename,string coursecode)//撰寫函式方便管理者日後新增課程
        {
            if (dicCourse.ContainsKey(coursecode) == false)
            {
                dicCourse.Add(coursecode, coursename);
                dicCourseAdvice.Add(coursecode,coursename);
            }
            else
            {
                throw new Exception("此課程已存在");
            }
        }                     //課程代碼        //意見
        public void ca(string coursecode,string advice)//建構函式將教學意見存入字典
        {
            if (dicCourse.ContainsKey(coursecode))
            {
                dicCourseAdvice[coursecode] += advice+"\n";
            }
            else
            {
                throw new Exception("無此課程");
            }
        }                           //課程代碼
        public int CreateDic(string coursecode)//建立已選課程清單，判定是否重複選取並輸出學分數
        {
            if (dicCourse.ContainsKey(coursecode) && dicCourseHaveChoosed.ContainsKey(coursecode) == false)
            {
                dicCourseHaveChoosed.Add(coursecode, true);
                return dicCoursePoint[coursecode];//傳回課程學分數(int)
            }
            else 
            {
                throw new Exception("此課程已選!!!");//丟回此課已選的例外
            }
            
                
        }
                                        //課程代碼
        public string CourseCheck(string coursecode)//建構函式查詢現有的課程
        {
            if (dicCourse.ContainsKey(coursecode))
            {
                return dicCourse[coursecode];//輸出課程名稱
            }
            else
            {
                return "無此課程";//輸出"無此課程"的字串

            }

        }
        
        public string DepNum(string coursecode)
        {
            return coursecode.Substring(0, 2);//擷取前兩個字元即獲得開課學院代號
        }

        public bool MedicineOrNot(string coursecode)
        {
            //{ "理學院", "工學院", "醫學院", "文學院" , "生物科學與科技學院","通識課程" }
            if (coursecode == "醫學院") return true;
            else return false;
        }


    }
        
       
    
}
