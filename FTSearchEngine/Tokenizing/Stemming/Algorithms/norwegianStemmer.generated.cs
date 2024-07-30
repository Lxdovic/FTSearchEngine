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
    public partial class NorwegianStemmer : Stemmer
    {
        private int I_x;
        private int I_p1;

        private const string g_v = "aeiouy\u00E6\u00E5\u00F8";
        private const string g_s_ending = "bcdfghjlmnoprtvyz";
        private static readonly Among[] a_0 = new[] 
        {
            new Among("a", -1, 1),
            new Among("e", -1, 1),
            new Among("ede", 1, 1),
            new Among("ande", 1, 1),
            new Among("ende", 1, 1),
            new Among("ane", 1, 1),
            new Among("ene", 1, 1),
            new Among("hetene", 6, 1),
            new Among("erte", 1, 3),
            new Among("en", -1, 1),
            new Among("heten", 9, 1),
            new Among("ar", -1, 1),
            new Among("er", -1, 1),
            new Among("heter", 12, 1),
            new Among("s", -1, 2),
            new Among("as", 14, 1),
            new Among("es", 14, 1),
            new Among("edes", 16, 1),
            new Among("endes", 16, 1),
            new Among("enes", 16, 1),
            new Among("hetenes", 19, 1),
            new Among("ens", 14, 1),
            new Among("hetens", 21, 1),
            new Among("ers", 14, 1),
            new Among("ets", 14, 1),
            new Among("et", -1, 1),
            new Among("het", 25, 1),
            new Among("ert", -1, 3),
            new Among("ast", -1, 1)
        };

        private static readonly Among[] a_1 = new[] 
        {
            new Among("dt", -1, -1),
            new Among("vt", -1, -1)
        };

        private static readonly Among[] a_2 = new[] 
        {
            new Among("leg", -1, 1),
            new Among("eleg", 0, 1),
            new Among("ig", -1, 1),
            new Among("eig", 2, 1),
            new Among("lig", 2, 1),
            new Among("elig", 4, 1),
            new Among("els", -1, 1),
            new Among("lov", -1, 1),
            new Among("elov", 7, 1),
            new Among("slov", 7, 1),
            new Among("hetslov", 9, 1)
        };



        private bool r_mark_regions()
        {
            I_p1 = limit;
            {
                int c1 = cursor;
                {
                    int c = cursor + 3;
                    if (c > limit)
                    {
                        return false;
                    }
                    cursor = c;
                }
                I_x = cursor;
                cursor = c1;
            }
            if (out_grouping(g_v, 97, 248, true) < 0)
            {
                return false;
            }

            {

                int ret = in_grouping(g_v, 97, 248, true);
                if (ret < 0)
                {
                    return false;
                }

                cursor += ret;
            }
            I_p1 = cursor;
            if (!(I_p1 < I_x))
            {
                goto lab0;
            }
            I_p1 = I_x;
        lab0: ; 
            return true;
        }

        private bool r_main_suffix()
        {
            int among_var;
            if (cursor < I_p1)
            {
                return false;
            }
            int c2 = limit_backward;
            limit_backward = I_p1;
            ket = cursor;
            among_var = find_among_b(a_0);
            if (among_var == 0)
            {
                {
                    limit_backward = c2;
                    return false;
                }
            }
            bra = cursor;
            limit_backward = c2;
            switch (among_var) {
                case 1:
                    slice_del();
                    break;
                case 2:
                    {
                        int c3 = limit - cursor;
                        if (in_grouping_b(g_s_ending, 98, 122, false) != 0)
                        {
                            goto lab1;
                        }
                        goto lab0;
                    lab1: ; 
                        cursor = limit - c3;
                        if (!(eq_s_b("k")))
                        {
                            return false;
                        }
                        if (out_grouping_b(g_v, 97, 248, false) != 0)
                        {
                            return false;
                        }
                    }
                lab0: ; 
                    slice_del();
                    break;
                case 3:
                    slice_from("er");
                    break;
            }
            return true;
        }

        private bool r_consonant_pair()
        {
            {
                int c1 = limit - cursor;
                if (cursor < I_p1)
                {
                    return false;
                }
                int c3 = limit_backward;
                limit_backward = I_p1;
                ket = cursor;
                if (find_among_b(a_1) == 0)
                {
                    {
                        limit_backward = c3;
                        return false;
                    }
                }
                bra = cursor;
                limit_backward = c3;
                cursor = limit - c1;
            }
            if (cursor <= limit_backward)
            {
                return false;
            }
            cursor--;
            bra = cursor;
            slice_del();
            return true;
        }

        private bool r_other_suffix()
        {
            if (cursor < I_p1)
            {
                return false;
            }
            int c2 = limit_backward;
            limit_backward = I_p1;
            ket = cursor;
            if (find_among_b(a_2) == 0)
            {
                {
                    limit_backward = c2;
                    return false;
                }
            }
            bra = cursor;
            limit_backward = c2;
            slice_del();
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
                r_main_suffix();
                cursor = limit - c2;
            }
            {
                int c3 = limit - cursor;
                r_consonant_pair();
                cursor = limit - c3;
            }
            {
                int c4 = limit - cursor;
                r_other_suffix();
                cursor = limit - c4;
            }
            cursor = limit_backward;
            return true;
        }

    }
}
