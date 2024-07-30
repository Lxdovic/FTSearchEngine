// Generated by Snowball 2.2.0 - https://snowballstem.org/

using FTSearchEngine.Stemming;

#pragma warning disable 0164
#pragma warning disable 0162

namespace Snowball
{
    using System;
    using System.Text;
    
    ///<summary>
    ///  This class implements the stemming algorithm defined by a snowball script.
    ///  Generated by Snowball 2.2.0 - https://snowballstem.org/
    ///</summary>
    /// 
    [System.CodeDom.Compiler.GeneratedCode("Snowball", "2.2.0")]
    public partial class HungarianStemmer : Stemmer
    {
        private int I_p1;

        private const string g_v = "aeiou\u00E1\u00E9\u00ED\u00F3\u00F6\u0151\u00FA\u00FC\u0171";
        private static readonly Among[] a_0 = new[] 
        {
            new Among("cs", -1, -1),
            new Among("dzs", -1, -1),
            new Among("gy", -1, -1),
            new Among("ly", -1, -1),
            new Among("ny", -1, -1),
            new Among("sz", -1, -1),
            new Among("ty", -1, -1),
            new Among("zs", -1, -1)
        };

        private static readonly Among[] a_1 = new[] 
        {
            new Among("\u00E1", -1, 1),
            new Among("\u00E9", -1, 2)
        };

        private static readonly Among[] a_2 = new[] 
        {
            new Among("bb", -1, -1),
            new Among("cc", -1, -1),
            new Among("dd", -1, -1),
            new Among("ff", -1, -1),
            new Among("gg", -1, -1),
            new Among("jj", -1, -1),
            new Among("kk", -1, -1),
            new Among("ll", -1, -1),
            new Among("mm", -1, -1),
            new Among("nn", -1, -1),
            new Among("pp", -1, -1),
            new Among("rr", -1, -1),
            new Among("ccs", -1, -1),
            new Among("ss", -1, -1),
            new Among("zzs", -1, -1),
            new Among("tt", -1, -1),
            new Among("vv", -1, -1),
            new Among("ggy", -1, -1),
            new Among("lly", -1, -1),
            new Among("nny", -1, -1),
            new Among("tty", -1, -1),
            new Among("ssz", -1, -1),
            new Among("zz", -1, -1)
        };

        private static readonly Among[] a_3 = new[] 
        {
            new Among("al", -1, 1),
            new Among("el", -1, 1)
        };

        private static readonly Among[] a_4 = new[] 
        {
            new Among("ba", -1, -1),
            new Among("ra", -1, -1),
            new Among("be", -1, -1),
            new Among("re", -1, -1),
            new Among("ig", -1, -1),
            new Among("nak", -1, -1),
            new Among("nek", -1, -1),
            new Among("val", -1, -1),
            new Among("vel", -1, -1),
            new Among("ul", -1, -1),
            new Among("n\u00E1l", -1, -1),
            new Among("n\u00E9l", -1, -1),
            new Among("b\u00F3l", -1, -1),
            new Among("r\u00F3l", -1, -1),
            new Among("t\u00F3l", -1, -1),
            new Among("\u00FCl", -1, -1),
            new Among("b\u0151l", -1, -1),
            new Among("r\u0151l", -1, -1),
            new Among("t\u0151l", -1, -1),
            new Among("n", -1, -1),
            new Among("an", 19, -1),
            new Among("ban", 20, -1),
            new Among("en", 19, -1),
            new Among("ben", 22, -1),
            new Among("k\u00E9ppen", 22, -1),
            new Among("on", 19, -1),
            new Among("\u00F6n", 19, -1),
            new Among("k\u00E9pp", -1, -1),
            new Among("kor", -1, -1),
            new Among("t", -1, -1),
            new Among("at", 29, -1),
            new Among("et", 29, -1),
            new Among("k\u00E9nt", 29, -1),
            new Among("ank\u00E9nt", 32, -1),
            new Among("enk\u00E9nt", 32, -1),
            new Among("onk\u00E9nt", 32, -1),
            new Among("ot", 29, -1),
            new Among("\u00E9rt", 29, -1),
            new Among("\u00F6t", 29, -1),
            new Among("hez", -1, -1),
            new Among("hoz", -1, -1),
            new Among("h\u00F6z", -1, -1),
            new Among("v\u00E1", -1, -1),
            new Among("v\u00E9", -1, -1)
        };

        private static readonly Among[] a_5 = new[] 
        {
            new Among("\u00E1n", -1, 2),
            new Among("\u00E9n", -1, 1),
            new Among("\u00E1nk\u00E9nt", -1, 2)
        };

        private static readonly Among[] a_6 = new[] 
        {
            new Among("stul", -1, 1),
            new Among("astul", 0, 1),
            new Among("\u00E1stul", 0, 2),
            new Among("st\u00FCl", -1, 1),
            new Among("est\u00FCl", 3, 1),
            new Among("\u00E9st\u00FCl", 3, 3)
        };

        private static readonly Among[] a_7 = new[] 
        {
            new Among("\u00E1", -1, 1),
            new Among("\u00E9", -1, 1)
        };

        private static readonly Among[] a_8 = new[] 
        {
            new Among("k", -1, 3),
            new Among("ak", 0, 3),
            new Among("ek", 0, 3),
            new Among("ok", 0, 3),
            new Among("\u00E1k", 0, 1),
            new Among("\u00E9k", 0, 2),
            new Among("\u00F6k", 0, 3)
        };

        private static readonly Among[] a_9 = new[] 
        {
            new Among("\u00E9i", -1, 1),
            new Among("\u00E1\u00E9i", 0, 3),
            new Among("\u00E9\u00E9i", 0, 2),
            new Among("\u00E9", -1, 1),
            new Among("k\u00E9", 3, 1),
            new Among("ak\u00E9", 4, 1),
            new Among("ek\u00E9", 4, 1),
            new Among("ok\u00E9", 4, 1),
            new Among("\u00E1k\u00E9", 4, 3),
            new Among("\u00E9k\u00E9", 4, 2),
            new Among("\u00F6k\u00E9", 4, 1),
            new Among("\u00E9\u00E9", 3, 2)
        };

        private static readonly Among[] a_10 = new[] 
        {
            new Among("a", -1, 1),
            new Among("ja", 0, 1),
            new Among("d", -1, 1),
            new Among("ad", 2, 1),
            new Among("ed", 2, 1),
            new Among("od", 2, 1),
            new Among("\u00E1d", 2, 2),
            new Among("\u00E9d", 2, 3),
            new Among("\u00F6d", 2, 1),
            new Among("e", -1, 1),
            new Among("je", 9, 1),
            new Among("nk", -1, 1),
            new Among("unk", 11, 1),
            new Among("\u00E1nk", 11, 2),
            new Among("\u00E9nk", 11, 3),
            new Among("\u00FCnk", 11, 1),
            new Among("uk", -1, 1),
            new Among("juk", 16, 1),
            new Among("\u00E1juk", 17, 2),
            new Among("\u00FCk", -1, 1),
            new Among("j\u00FCk", 19, 1),
            new Among("\u00E9j\u00FCk", 20, 3),
            new Among("m", -1, 1),
            new Among("am", 22, 1),
            new Among("em", 22, 1),
            new Among("om", 22, 1),
            new Among("\u00E1m", 22, 2),
            new Among("\u00E9m", 22, 3),
            new Among("o", -1, 1),
            new Among("\u00E1", -1, 2),
            new Among("\u00E9", -1, 3)
        };

        private static readonly Among[] a_11 = new[] 
        {
            new Among("id", -1, 1),
            new Among("aid", 0, 1),
            new Among("jaid", 1, 1),
            new Among("eid", 0, 1),
            new Among("jeid", 3, 1),
            new Among("\u00E1id", 0, 2),
            new Among("\u00E9id", 0, 3),
            new Among("i", -1, 1),
            new Among("ai", 7, 1),
            new Among("jai", 8, 1),
            new Among("ei", 7, 1),
            new Among("jei", 10, 1),
            new Among("\u00E1i", 7, 2),
            new Among("\u00E9i", 7, 3),
            new Among("itek", -1, 1),
            new Among("eitek", 14, 1),
            new Among("jeitek", 15, 1),
            new Among("\u00E9itek", 14, 3),
            new Among("ik", -1, 1),
            new Among("aik", 18, 1),
            new Among("jaik", 19, 1),
            new Among("eik", 18, 1),
            new Among("jeik", 21, 1),
            new Among("\u00E1ik", 18, 2),
            new Among("\u00E9ik", 18, 3),
            new Among("ink", -1, 1),
            new Among("aink", 25, 1),
            new Among("jaink", 26, 1),
            new Among("eink", 25, 1),
            new Among("jeink", 28, 1),
            new Among("\u00E1ink", 25, 2),
            new Among("\u00E9ink", 25, 3),
            new Among("aitok", -1, 1),
            new Among("jaitok", 32, 1),
            new Among("\u00E1itok", -1, 2),
            new Among("im", -1, 1),
            new Among("aim", 35, 1),
            new Among("jaim", 36, 1),
            new Among("eim", 35, 1),
            new Among("jeim", 38, 1),
            new Among("\u00E1im", 35, 2),
            new Among("\u00E9im", 35, 3)
        };



        private bool r_mark_regions()
        {
            I_p1 = limit;
            {
                int c1 = cursor;
                if (in_grouping(g_v, 97, 369, false) != 0)
                {
                    goto lab1;
                }
                if (in_grouping(g_v, 97, 369, true) < 0)
                {
                    goto lab1;
                }

                {
                    int c3 = cursor;
                    if (find_among(a_0) == 0)
                    {
                        goto lab3;
                    }
                    goto lab2;
                lab3: ; 
                    cursor = c3;
                    if (cursor >= limit)
                    {
                        goto lab1;
                    }
                    cursor++;
                }
            lab2: ; 
                I_p1 = cursor;
                goto lab0;
            lab1: ; 
                cursor = c1;
                if (out_grouping(g_v, 97, 369, false) != 0)
                {
                    return false;
                }
                {

                    int ret = out_grouping(g_v, 97, 369, true);
                    if (ret < 0)
                    {
                        return false;
                    }

                    cursor += ret;
                }
                I_p1 = cursor;
            }
        lab0: ; 
            return true;
        }

        private bool r_R1()
        {
            if (!(I_p1 <= cursor))
            {
                return false;
            }
            return true;
        }

        private bool r_v_ending()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_1);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            switch (among_var) {
                case 1:
                    slice_from("a");
                    break;
                case 2:
                    slice_from("e");
                    break;
            }
            return true;
        }

        private bool r_double()
        {
            {
                int c1 = limit - cursor;
                if (find_among_b(a_2) == 0)
                {
                    return false;
                }
                cursor = limit - c1;
            }
            return true;
        }

        private bool r_undouble()
        {
            if (cursor <= limit_backward)
            {
                return false;
            }
            cursor--;
            ket = cursor;
            {
                int c = cursor - 1;
                if (c < limit_backward)
                {
                    return false;
                }
                cursor = c;
            }
            bra = cursor;
            slice_del();
            return true;
        }

        private bool r_instrum()
        {
            ket = cursor;
            if (find_among_b(a_3) == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            if (!r_double())
                return false;
            slice_del();
            if (!r_undouble())
                return false;
            return true;
        }

        private bool r_case()
        {
            ket = cursor;
            if (find_among_b(a_4) == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            slice_del();
            if (!r_v_ending())
                return false;
            return true;
        }

        private bool r_case_special()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_5);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            switch (among_var) {
                case 1:
                    slice_from("e");
                    break;
                case 2:
                    slice_from("a");
                    break;
            }
            return true;
        }

        private bool r_case_other()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_6);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            switch (among_var) {
                case 1:
                    slice_del();
                    break;
                case 2:
                    slice_from("a");
                    break;
                case 3:
                    slice_from("e");
                    break;
            }
            return true;
        }

        private bool r_factive()
        {
            ket = cursor;
            if (find_among_b(a_7) == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            if (!r_double())
                return false;
            slice_del();
            if (!r_undouble())
                return false;
            return true;
        }

        private bool r_plural()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_8);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            switch (among_var) {
                case 1:
                    slice_from("a");
                    break;
                case 2:
                    slice_from("e");
                    break;
                case 3:
                    slice_del();
                    break;
            }
            return true;
        }

        private bool r_owned()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_9);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            switch (among_var) {
                case 1:
                    slice_del();
                    break;
                case 2:
                    slice_from("e");
                    break;
                case 3:
                    slice_from("a");
                    break;
            }
            return true;
        }

        private bool r_sing_owner()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_10);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            switch (among_var) {
                case 1:
                    slice_del();
                    break;
                case 2:
                    slice_from("a");
                    break;
                case 3:
                    slice_from("e");
                    break;
            }
            return true;
        }

        private bool r_plur_owner()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_11);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R1())
                return false;
            switch (among_var) {
                case 1:
                    slice_del();
                    break;
                case 2:
                    slice_from("a");
                    break;
                case 3:
                    slice_from("e");
                    break;
            }
            return true;
        }

        protected override bool stem()
        {
            {
                int c1 = cursor;
                r_mark_regions();
                cursor = c1;
            }
            limit_backward = cursor;
            cursor = limit;
            {
                int c2 = limit - cursor;
                r_instrum();
                cursor = limit - c2;
            }
            {
                int c3 = limit - cursor;
                r_case();
                cursor = limit - c3;
            }
            {
                int c4 = limit - cursor;
                r_case_special();
                cursor = limit - c4;
            }
            {
                int c5 = limit - cursor;
                r_case_other();
                cursor = limit - c5;
            }
            {
                int c6 = limit - cursor;
                r_factive();
                cursor = limit - c6;
            }
            {
                int c7 = limit - cursor;
                r_owned();
                cursor = limit - c7;
            }
            {
                int c8 = limit - cursor;
                r_sing_owner();
                cursor = limit - c8;
            }
            {
                int c9 = limit - cursor;
                r_plur_owner();
                cursor = limit - c9;
            }
            {
                int c10 = limit - cursor;
                r_plural();
                cursor = limit - c10;
            }
            cursor = limit_backward;
            return true;
        }

    }
}

