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
    public partial class RussianStemmer : Stemmer
    {
        private int I_p2;
        private int I_pV;

        private const string g_v = "\u0430\u0435\u0438\u043E\u0443\u044B\u044D\u044E\u044F";
        private static readonly Among[] a_0 = new[] 
        {
            new Among("\u0432", -1, 1),
            new Among("\u0438\u0432", 0, 2),
            new Among("\u044B\u0432", 0, 2),
            new Among("\u0432\u0448\u0438", -1, 1),
            new Among("\u0438\u0432\u0448\u0438", 3, 2),
            new Among("\u044B\u0432\u0448\u0438", 3, 2),
            new Among("\u0432\u0448\u0438\u0441\u044C", -1, 1),
            new Among("\u0438\u0432\u0448\u0438\u0441\u044C", 6, 2),
            new Among("\u044B\u0432\u0448\u0438\u0441\u044C", 6, 2)
        };

        private static readonly Among[] a_1 = new[] 
        {
            new Among("\u0435\u0435", -1, 1),
            new Among("\u0438\u0435", -1, 1),
            new Among("\u043E\u0435", -1, 1),
            new Among("\u044B\u0435", -1, 1),
            new Among("\u0438\u043C\u0438", -1, 1),
            new Among("\u044B\u043C\u0438", -1, 1),
            new Among("\u0435\u0439", -1, 1),
            new Among("\u0438\u0439", -1, 1),
            new Among("\u043E\u0439", -1, 1),
            new Among("\u044B\u0439", -1, 1),
            new Among("\u0435\u043C", -1, 1),
            new Among("\u0438\u043C", -1, 1),
            new Among("\u043E\u043C", -1, 1),
            new Among("\u044B\u043C", -1, 1),
            new Among("\u0435\u0433\u043E", -1, 1),
            new Among("\u043E\u0433\u043E", -1, 1),
            new Among("\u0435\u043C\u0443", -1, 1),
            new Among("\u043E\u043C\u0443", -1, 1),
            new Among("\u0438\u0445", -1, 1),
            new Among("\u044B\u0445", -1, 1),
            new Among("\u0435\u044E", -1, 1),
            new Among("\u043E\u044E", -1, 1),
            new Among("\u0443\u044E", -1, 1),
            new Among("\u044E\u044E", -1, 1),
            new Among("\u0430\u044F", -1, 1),
            new Among("\u044F\u044F", -1, 1)
        };

        private static readonly Among[] a_2 = new[] 
        {
            new Among("\u0435\u043C", -1, 1),
            new Among("\u043D\u043D", -1, 1),
            new Among("\u0432\u0448", -1, 1),
            new Among("\u0438\u0432\u0448", 2, 2),
            new Among("\u044B\u0432\u0448", 2, 2),
            new Among("\u0449", -1, 1),
            new Among("\u044E\u0449", 5, 1),
            new Among("\u0443\u044E\u0449", 6, 2)
        };

        private static readonly Among[] a_3 = new[] 
        {
            new Among("\u0441\u044C", -1, 1),
            new Among("\u0441\u044F", -1, 1)
        };

        private static readonly Among[] a_4 = new[] 
        {
            new Among("\u043B\u0430", -1, 1),
            new Among("\u0438\u043B\u0430", 0, 2),
            new Among("\u044B\u043B\u0430", 0, 2),
            new Among("\u043D\u0430", -1, 1),
            new Among("\u0435\u043D\u0430", 3, 2),
            new Among("\u0435\u0442\u0435", -1, 1),
            new Among("\u0438\u0442\u0435", -1, 2),
            new Among("\u0439\u0442\u0435", -1, 1),
            new Among("\u0435\u0439\u0442\u0435", 7, 2),
            new Among("\u0443\u0439\u0442\u0435", 7, 2),
            new Among("\u043B\u0438", -1, 1),
            new Among("\u0438\u043B\u0438", 10, 2),
            new Among("\u044B\u043B\u0438", 10, 2),
            new Among("\u0439", -1, 1),
            new Among("\u0435\u0439", 13, 2),
            new Among("\u0443\u0439", 13, 2),
            new Among("\u043B", -1, 1),
            new Among("\u0438\u043B", 16, 2),
            new Among("\u044B\u043B", 16, 2),
            new Among("\u0435\u043C", -1, 1),
            new Among("\u0438\u043C", -1, 2),
            new Among("\u044B\u043C", -1, 2),
            new Among("\u043D", -1, 1),
            new Among("\u0435\u043D", 22, 2),
            new Among("\u043B\u043E", -1, 1),
            new Among("\u0438\u043B\u043E", 24, 2),
            new Among("\u044B\u043B\u043E", 24, 2),
            new Among("\u043D\u043E", -1, 1),
            new Among("\u0435\u043D\u043E", 27, 2),
            new Among("\u043D\u043D\u043E", 27, 1),
            new Among("\u0435\u0442", -1, 1),
            new Among("\u0443\u0435\u0442", 30, 2),
            new Among("\u0438\u0442", -1, 2),
            new Among("\u044B\u0442", -1, 2),
            new Among("\u044E\u0442", -1, 1),
            new Among("\u0443\u044E\u0442", 34, 2),
            new Among("\u044F\u0442", -1, 2),
            new Among("\u043D\u044B", -1, 1),
            new Among("\u0435\u043D\u044B", 37, 2),
            new Among("\u0442\u044C", -1, 1),
            new Among("\u0438\u0442\u044C", 39, 2),
            new Among("\u044B\u0442\u044C", 39, 2),
            new Among("\u0435\u0448\u044C", -1, 1),
            new Among("\u0438\u0448\u044C", -1, 2),
            new Among("\u044E", -1, 2),
            new Among("\u0443\u044E", 44, 2)
        };

        private static readonly Among[] a_5 = new[] 
        {
            new Among("\u0430", -1, 1),
            new Among("\u0435\u0432", -1, 1),
            new Among("\u043E\u0432", -1, 1),
            new Among("\u0435", -1, 1),
            new Among("\u0438\u0435", 3, 1),
            new Among("\u044C\u0435", 3, 1),
            new Among("\u0438", -1, 1),
            new Among("\u0435\u0438", 6, 1),
            new Among("\u0438\u0438", 6, 1),
            new Among("\u0430\u043C\u0438", 6, 1),
            new Among("\u044F\u043C\u0438", 6, 1),
            new Among("\u0438\u044F\u043C\u0438", 10, 1),
            new Among("\u0439", -1, 1),
            new Among("\u0435\u0439", 12, 1),
            new Among("\u0438\u0435\u0439", 13, 1),
            new Among("\u0438\u0439", 12, 1),
            new Among("\u043E\u0439", 12, 1),
            new Among("\u0430\u043C", -1, 1),
            new Among("\u0435\u043C", -1, 1),
            new Among("\u0438\u0435\u043C", 18, 1),
            new Among("\u043E\u043C", -1, 1),
            new Among("\u044F\u043C", -1, 1),
            new Among("\u0438\u044F\u043C", 21, 1),
            new Among("\u043E", -1, 1),
            new Among("\u0443", -1, 1),
            new Among("\u0430\u0445", -1, 1),
            new Among("\u044F\u0445", -1, 1),
            new Among("\u0438\u044F\u0445", 26, 1),
            new Among("\u044B", -1, 1),
            new Among("\u044C", -1, 1),
            new Among("\u044E", -1, 1),
            new Among("\u0438\u044E", 30, 1),
            new Among("\u044C\u044E", 30, 1),
            new Among("\u044F", -1, 1),
            new Among("\u0438\u044F", 33, 1),
            new Among("\u044C\u044F", 33, 1)
        };

        private static readonly Among[] a_6 = new[] 
        {
            new Among("\u043E\u0441\u0442", -1, 1),
            new Among("\u043E\u0441\u0442\u044C", -1, 1)
        };

        private static readonly Among[] a_7 = new[] 
        {
            new Among("\u0435\u0439\u0448\u0435", -1, 1),
            new Among("\u043D", -1, 2),
            new Among("\u0435\u0439\u0448", -1, 1),
            new Among("\u044C", -1, 3)
        };



        private bool r_mark_regions()
        {
            I_pV = limit;
            I_p2 = limit;
            {
                int c1 = cursor;
                {

                    int ret = out_grouping(g_v, 1072, 1103, true);
                    if (ret < 0)
                    {
                        goto lab0;
                    }

                    cursor += ret;
                }
                I_pV = cursor;
                {

                    int ret = in_grouping(g_v, 1072, 1103, true);
                    if (ret < 0)
                    {
                        goto lab0;
                    }

                    cursor += ret;
                }
                {

                    int ret = out_grouping(g_v, 1072, 1103, true);
                    if (ret < 0)
                    {
                        goto lab0;
                    }

                    cursor += ret;
                }
                {

                    int ret = in_grouping(g_v, 1072, 1103, true);
                    if (ret < 0)
                    {
                        goto lab0;
                    }

                    cursor += ret;
                }
                I_p2 = cursor;
            lab0: ; 
                cursor = c1;
            }
            return true;
        }

        private bool r_R2()
        {
            if (!(I_p2 <= cursor))
            {
                return false;
            }
            return true;
        }

        private bool r_perfective_gerund()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_0);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            switch (among_var) {
                case 1:
                    {
                        int c1 = limit - cursor;
                        if (!(eq_s_b("\u0430")))
                        {
                            goto lab1;
                        }
                        goto lab0;
                    lab1: ; 
                        cursor = limit - c1;
                        if (!(eq_s_b("\u044F")))
                        {
                            return false;
                        }
                    }
                lab0: ; 
                    slice_del();
                    break;
                case 2:
                    slice_del();
                    break;
            }
            return true;
        }

        private bool r_adjective()
        {
            ket = cursor;
            if (find_among_b(a_1) == 0)
            {
                return false;
            }
            bra = cursor;
            slice_del();
            return true;
        }

        private bool r_adjectival()
        {
            int among_var;
            if (!r_adjective())
                return false;
            {
                int c1 = limit - cursor;
                ket = cursor;
                among_var = find_among_b(a_2);
                if (among_var == 0)
                {
                    {
                        cursor = limit - c1;
                        goto lab0;
                    }
                }
                bra = cursor;
                switch (among_var) {
                    case 1:
                        {
                            int c2 = limit - cursor;
                            if (!(eq_s_b("\u0430")))
                            {
                                goto lab2;
                            }
                            goto lab1;
                        lab2: ; 
                            cursor = limit - c2;
                            if (!(eq_s_b("\u044F")))
                            {
                                {
                                    cursor = limit - c1;
                                    goto lab0;
                                }
                            }
                        }
                    lab1: ; 
                        slice_del();
                        break;
                    case 2:
                        slice_del();
                        break;
                }
            lab0: ; 
            }
            return true;
        }

        private bool r_reflexive()
        {
            ket = cursor;
            if (find_among_b(a_3) == 0)
            {
                return false;
            }
            bra = cursor;
            slice_del();
            return true;
        }

        private bool r_verb()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_4);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            switch (among_var) {
                case 1:
                    {
                        int c1 = limit - cursor;
                        if (!(eq_s_b("\u0430")))
                        {
                            goto lab1;
                        }
                        goto lab0;
                    lab1: ; 
                        cursor = limit - c1;
                        if (!(eq_s_b("\u044F")))
                        {
                            return false;
                        }
                    }
                lab0: ; 
                    slice_del();
                    break;
                case 2:
                    slice_del();
                    break;
            }
            return true;
        }

        private bool r_noun()
        {
            ket = cursor;
            if (find_among_b(a_5) == 0)
            {
                return false;
            }
            bra = cursor;
            slice_del();
            return true;
        }

        private bool r_derivational()
        {
            ket = cursor;
            if (find_among_b(a_6) == 0)
            {
                return false;
            }
            bra = cursor;
            if (!r_R2())
                return false;
            slice_del();
            return true;
        }

        private bool r_tidy_up()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_7);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            switch (among_var) {
                case 1:
                    slice_del();
                    ket = cursor;
                    if (!(eq_s_b("\u043D")))
                    {
                        return false;
                    }
                    bra = cursor;
                    if (!(eq_s_b("\u043D")))
                    {
                        return false;
                    }
                    slice_del();
                    break;
                case 2:
                    if (!(eq_s_b("\u043D")))
                    {
                        return false;
                    }
                    slice_del();
                    break;
                case 3:
                    slice_del();
                    break;
            }
            return true;
        }

        protected override bool stem()
        {
            {
                int c1 = cursor;
                while (true)
                {
                    int c2 = cursor;
                    while (true)
                    {
                        int c3 = cursor;
                        bra = cursor;
                        if (!(eq_s("\u0451")))
                        {
                            goto lab2;
                        }
                        ket = cursor;
                        cursor = c3;
                        break;
                    lab2: ; 
                        cursor = c3;
                        if (cursor >= limit)
                        {
                            goto lab1;
                        }
                        cursor++;
                    }
                    slice_from("\u0435");
                    continue;
                lab1: ; 
                    cursor = c2;
                    break;
                }
                cursor = c1;
            }
            r_mark_regions();
            limit_backward = cursor;
            cursor = limit;
            if (cursor < I_pV)
            {
                return false;
            }
            int c6 = limit_backward;
            limit_backward = I_pV;
            {
                int c7 = limit - cursor;
                {
                    int c8 = limit - cursor;
                    if (!r_perfective_gerund())
                        goto lab5;
                    goto lab4;
                lab5: ; 
                    cursor = limit - c8;
                    {
                        int c9 = limit - cursor;
                        if (!r_reflexive())
                            {
                                cursor = limit - c9;
                                goto lab6;
                            }
                    lab6: ; 
                    }
                    {
                        int c10 = limit - cursor;
                        if (!r_adjectival())
                            goto lab8;
                        goto lab7;
                    lab8: ; 
                        cursor = limit - c10;
                        if (!r_verb())
                            goto lab9;
                        goto lab7;
                    lab9: ; 
                        cursor = limit - c10;
                        if (!r_noun())
                            goto lab3;
                    }
                lab7: ; 
                }
            lab4: ; 
            lab3: ; 
                cursor = limit - c7;
            }
            {
                int c11 = limit - cursor;
                ket = cursor;
                if (!(eq_s_b("\u0438")))
                {
                    {
                        cursor = limit - c11;
                        goto lab10;
                    }
                }
                bra = cursor;
                slice_del();
            lab10: ; 
            }
            {
                int c12 = limit - cursor;
                r_derivational();
                cursor = limit - c12;
            }
            {
                int c13 = limit - cursor;
                r_tidy_up();
                cursor = limit - c13;
            }
            limit_backward = c6;
            cursor = limit_backward;
            return true;
        }

    }
}

