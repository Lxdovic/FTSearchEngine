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
    public partial class SpanishStemmer : Stemmer
    {
        private int I_p2;
        private int I_p1;
        private int I_pV;

        private const string g_v = "aeiou\u00E1\u00E9\u00ED\u00F3\u00FA\u00FC";
        private static readonly Among[] a_0 = new[] 
        {
            new Among("", -1, 6),
            new Among("\u00E1", 0, 1),
            new Among("\u00E9", 0, 2),
            new Among("\u00ED", 0, 3),
            new Among("\u00F3", 0, 4),
            new Among("\u00FA", 0, 5)
        };

        private static readonly Among[] a_1 = new[] 
        {
            new Among("la", -1, -1),
            new Among("sela", 0, -1),
            new Among("le", -1, -1),
            new Among("me", -1, -1),
            new Among("se", -1, -1),
            new Among("lo", -1, -1),
            new Among("selo", 5, -1),
            new Among("las", -1, -1),
            new Among("selas", 7, -1),
            new Among("les", -1, -1),
            new Among("los", -1, -1),
            new Among("selos", 10, -1),
            new Among("nos", -1, -1)
        };

        private static readonly Among[] a_2 = new[] 
        {
            new Among("ando", -1, 6),
            new Among("iendo", -1, 6),
            new Among("yendo", -1, 7),
            new Among("\u00E1ndo", -1, 2),
            new Among("i\u00E9ndo", -1, 1),
            new Among("ar", -1, 6),
            new Among("er", -1, 6),
            new Among("ir", -1, 6),
            new Among("\u00E1r", -1, 3),
            new Among("\u00E9r", -1, 4),
            new Among("\u00EDr", -1, 5)
        };

        private static readonly Among[] a_3 = new[] 
        {
            new Among("ic", -1, -1),
            new Among("ad", -1, -1),
            new Among("os", -1, -1),
            new Among("iv", -1, 1)
        };

        private static readonly Among[] a_4 = new[] 
        {
            new Among("able", -1, 1),
            new Among("ible", -1, 1),
            new Among("ante", -1, 1)
        };

        private static readonly Among[] a_5 = new[] 
        {
            new Among("ic", -1, 1),
            new Among("abil", -1, 1),
            new Among("iv", -1, 1)
        };

        private static readonly Among[] a_6 = new[] 
        {
            new Among("ica", -1, 1),
            new Among("ancia", -1, 2),
            new Among("encia", -1, 5),
            new Among("adora", -1, 2),
            new Among("osa", -1, 1),
            new Among("ista", -1, 1),
            new Among("iva", -1, 9),
            new Among("anza", -1, 1),
            new Among("log\u00EDa", -1, 3),
            new Among("idad", -1, 8),
            new Among("able", -1, 1),
            new Among("ible", -1, 1),
            new Among("ante", -1, 2),
            new Among("mente", -1, 7),
            new Among("amente", 13, 6),
            new Among("aci\u00F3n", -1, 2),
            new Among("uci\u00F3n", -1, 4),
            new Among("ico", -1, 1),
            new Among("ismo", -1, 1),
            new Among("oso", -1, 1),
            new Among("amiento", -1, 1),
            new Among("imiento", -1, 1),
            new Among("ivo", -1, 9),
            new Among("ador", -1, 2),
            new Among("icas", -1, 1),
            new Among("ancias", -1, 2),
            new Among("encias", -1, 5),
            new Among("adoras", -1, 2),
            new Among("osas", -1, 1),
            new Among("istas", -1, 1),
            new Among("ivas", -1, 9),
            new Among("anzas", -1, 1),
            new Among("log\u00EDas", -1, 3),
            new Among("idades", -1, 8),
            new Among("ables", -1, 1),
            new Among("ibles", -1, 1),
            new Among("aciones", -1, 2),
            new Among("uciones", -1, 4),
            new Among("adores", -1, 2),
            new Among("antes", -1, 2),
            new Among("icos", -1, 1),
            new Among("ismos", -1, 1),
            new Among("osos", -1, 1),
            new Among("amientos", -1, 1),
            new Among("imientos", -1, 1),
            new Among("ivos", -1, 9)
        };

        private static readonly Among[] a_7 = new[] 
        {
            new Among("ya", -1, 1),
            new Among("ye", -1, 1),
            new Among("yan", -1, 1),
            new Among("yen", -1, 1),
            new Among("yeron", -1, 1),
            new Among("yendo", -1, 1),
            new Among("yo", -1, 1),
            new Among("yas", -1, 1),
            new Among("yes", -1, 1),
            new Among("yais", -1, 1),
            new Among("yamos", -1, 1),
            new Among("y\u00F3", -1, 1)
        };

        private static readonly Among[] a_8 = new[] 
        {
            new Among("aba", -1, 2),
            new Among("ada", -1, 2),
            new Among("ida", -1, 2),
            new Among("ara", -1, 2),
            new Among("iera", -1, 2),
            new Among("\u00EDa", -1, 2),
            new Among("ar\u00EDa", 5, 2),
            new Among("er\u00EDa", 5, 2),
            new Among("ir\u00EDa", 5, 2),
            new Among("ad", -1, 2),
            new Among("ed", -1, 2),
            new Among("id", -1, 2),
            new Among("ase", -1, 2),
            new Among("iese", -1, 2),
            new Among("aste", -1, 2),
            new Among("iste", -1, 2),
            new Among("an", -1, 2),
            new Among("aban", 16, 2),
            new Among("aran", 16, 2),
            new Among("ieran", 16, 2),
            new Among("\u00EDan", 16, 2),
            new Among("ar\u00EDan", 20, 2),
            new Among("er\u00EDan", 20, 2),
            new Among("ir\u00EDan", 20, 2),
            new Among("en", -1, 1),
            new Among("asen", 24, 2),
            new Among("iesen", 24, 2),
            new Among("aron", -1, 2),
            new Among("ieron", -1, 2),
            new Among("ar\u00E1n", -1, 2),
            new Among("er\u00E1n", -1, 2),
            new Among("ir\u00E1n", -1, 2),
            new Among("ado", -1, 2),
            new Among("ido", -1, 2),
            new Among("ando", -1, 2),
            new Among("iendo", -1, 2),
            new Among("ar", -1, 2),
            new Among("er", -1, 2),
            new Among("ir", -1, 2),
            new Among("as", -1, 2),
            new Among("abas", 39, 2),
            new Among("adas", 39, 2),
            new Among("idas", 39, 2),
            new Among("aras", 39, 2),
            new Among("ieras", 39, 2),
            new Among("\u00EDas", 39, 2),
            new Among("ar\u00EDas", 45, 2),
            new Among("er\u00EDas", 45, 2),
            new Among("ir\u00EDas", 45, 2),
            new Among("es", -1, 1),
            new Among("ases", 49, 2),
            new Among("ieses", 49, 2),
            new Among("abais", -1, 2),
            new Among("arais", -1, 2),
            new Among("ierais", -1, 2),
            new Among("\u00EDais", -1, 2),
            new Among("ar\u00EDais", 55, 2),
            new Among("er\u00EDais", 55, 2),
            new Among("ir\u00EDais", 55, 2),
            new Among("aseis", -1, 2),
            new Among("ieseis", -1, 2),
            new Among("asteis", -1, 2),
            new Among("isteis", -1, 2),
            new Among("\u00E1is", -1, 2),
            new Among("\u00E9is", -1, 1),
            new Among("ar\u00E9is", 64, 2),
            new Among("er\u00E9is", 64, 2),
            new Among("ir\u00E9is", 64, 2),
            new Among("ados", -1, 2),
            new Among("idos", -1, 2),
            new Among("amos", -1, 2),
            new Among("\u00E1bamos", 70, 2),
            new Among("\u00E1ramos", 70, 2),
            new Among("i\u00E9ramos", 70, 2),
            new Among("\u00EDamos", 70, 2),
            new Among("ar\u00EDamos", 74, 2),
            new Among("er\u00EDamos", 74, 2),
            new Among("ir\u00EDamos", 74, 2),
            new Among("emos", -1, 1),
            new Among("aremos", 78, 2),
            new Among("eremos", 78, 2),
            new Among("iremos", 78, 2),
            new Among("\u00E1semos", 78, 2),
            new Among("i\u00E9semos", 78, 2),
            new Among("imos", -1, 2),
            new Among("ar\u00E1s", -1, 2),
            new Among("er\u00E1s", -1, 2),
            new Among("ir\u00E1s", -1, 2),
            new Among("\u00EDs", -1, 2),
            new Among("ar\u00E1", -1, 2),
            new Among("er\u00E1", -1, 2),
            new Among("ir\u00E1", -1, 2),
            new Among("ar\u00E9", -1, 2),
            new Among("er\u00E9", -1, 2),
            new Among("ir\u00E9", -1, 2),
            new Among("i\u00F3", -1, 2)
        };

        private static readonly Among[] a_9 = new[] 
        {
            new Among("a", -1, 1),
            new Among("e", -1, 2),
            new Among("o", -1, 1),
            new Among("os", -1, 1),
            new Among("\u00E1", -1, 1),
            new Among("\u00E9", -1, 2),
            new Among("\u00ED", -1, 1),
            new Among("\u00F3", -1, 1)
        };



        private bool r_mark_regions()
        {
            I_pV = limit;
            I_p1 = limit;
            I_p2 = limit;
            {
                int c1 = cursor;
                {
                    int c2 = cursor;
                    if (in_grouping(g_v, 97, 252, false) != 0)
                    {
                        goto lab2;
                    }
                    {
                        int c3 = cursor;
                        if (out_grouping(g_v, 97, 252, false) != 0)
                        {
                            goto lab4;
                        }
                        {

                            int ret = out_grouping(g_v, 97, 252, true);
                            if (ret < 0)
                            {
                                goto lab4;
                            }

                            cursor += ret;
                        }
                        goto lab3;
                    lab4: ; 
                        cursor = c3;
                        if (in_grouping(g_v, 97, 252, false) != 0)
                        {
                            goto lab2;
                        }
                        {

                            int ret = in_grouping(g_v, 97, 252, true);
                            if (ret < 0)
                            {
                                goto lab2;
                            }

                            cursor += ret;
                        }
                    }
                lab3: ; 
                    goto lab1;
                lab2: ; 
                    cursor = c2;
                    if (out_grouping(g_v, 97, 252, false) != 0)
                    {
                        goto lab0;
                    }
                    {
                        int c6 = cursor;
                        if (out_grouping(g_v, 97, 252, false) != 0)
                        {
                            goto lab6;
                        }
                        {

                            int ret = out_grouping(g_v, 97, 252, true);
                            if (ret < 0)
                            {
                                goto lab6;
                            }

                            cursor += ret;
                        }
                        goto lab5;
                    lab6: ; 
                        cursor = c6;
                        if (in_grouping(g_v, 97, 252, false) != 0)
                        {
                            goto lab0;
                        }
                        if (cursor >= limit)
                        {
                            goto lab0;
                        }
                        cursor++;
                    }
                lab5: ; 
                }
            lab1: ; 
                I_pV = cursor;
            lab0: ; 
                cursor = c1;
            }
            {
                int c8 = cursor;
                {

                    int ret = out_grouping(g_v, 97, 252, true);
                    if (ret < 0)
                    {
                        goto lab7;
                    }

                    cursor += ret;
                }
                {

                    int ret = in_grouping(g_v, 97, 252, true);
                    if (ret < 0)
                    {
                        goto lab7;
                    }

                    cursor += ret;
                }
                I_p1 = cursor;
                {

                    int ret = out_grouping(g_v, 97, 252, true);
                    if (ret < 0)
                    {
                        goto lab7;
                    }

                    cursor += ret;
                }
                {

                    int ret = in_grouping(g_v, 97, 252, true);
                    if (ret < 0)
                    {
                        goto lab7;
                    }

                    cursor += ret;
                }
                I_p2 = cursor;
            lab7: ; 
                cursor = c8;
            }
            return true;
        }

        private bool r_postlude()
        {
            int among_var;
            while (true)
            {
                int c1 = cursor;
                bra = cursor;
                among_var = find_among(a_0);
                if (among_var == 0)
                {
                    goto lab0;
                }
                ket = cursor;
                switch (among_var) {
                    case 1:
                        slice_from("a");
                        break;
                    case 2:
                        slice_from("e");
                        break;
                    case 3:
                        slice_from("i");
                        break;
                    case 4:
                        slice_from("o");
                        break;
                    case 5:
                        slice_from("u");
                        break;
                    case 6:
                        if (cursor >= limit)
                        {
                            goto lab0;
                        }
                        cursor++;
                        break;
                }
                continue;
            lab0: ; 
                cursor = c1;
                break;
            }
            return true;
        }

        private bool r_RV()
        {
            if (!(I_pV <= cursor))
            {
                return false;
            }
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

        private bool r_R2()
        {
            if (!(I_p2 <= cursor))
            {
                return false;
            }
            return true;
        }

        private bool r_attached_pronoun()
        {
            int among_var;
            ket = cursor;
            if (find_among_b(a_1) == 0)
            {
                return false;
            }
            bra = cursor;
            among_var = find_among_b(a_2);
            if (among_var == 0)
            {
                return false;
            }
            if (!r_RV())
                return false;
            switch (among_var) {
                case 1:
                    bra = cursor;
                    slice_from("iendo");
                    break;
                case 2:
                    bra = cursor;
                    slice_from("ando");
                    break;
                case 3:
                    bra = cursor;
                    slice_from("ar");
                    break;
                case 4:
                    bra = cursor;
                    slice_from("er");
                    break;
                case 5:
                    bra = cursor;
                    slice_from("ir");
                    break;
                case 6:
                    slice_del();
                    break;
                case 7:
                    if (!(eq_s_b("u")))
                    {
                        return false;
                    }
                    slice_del();
                    break;
            }
            return true;
        }

        private bool r_standard_suffix()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_6);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            switch (among_var) {
                case 1:
                    if (!r_R2())
                        return false;
                    slice_del();
                    break;
                case 2:
                    if (!r_R2())
                        return false;
                    slice_del();
                    {
                        int c1 = limit - cursor;
                        ket = cursor;
                        if (!(eq_s_b("ic")))
                        {
                            {
                                cursor = limit - c1;
                                goto lab0;
                            }
                        }
                        bra = cursor;
                        if (!r_R2())
                            {
                                cursor = limit - c1;
                                goto lab0;
                            }
                        slice_del();
                    lab0: ; 
                    }
                    break;
                case 3:
                    if (!r_R2())
                        return false;
                    slice_from("log");
                    break;
                case 4:
                    if (!r_R2())
                        return false;
                    slice_from("u");
                    break;
                case 5:
                    if (!r_R2())
                        return false;
                    slice_from("ente");
                    break;
                case 6:
                    if (!r_R1())
                        return false;
                    slice_del();
                    {
                        int c2 = limit - cursor;
                        ket = cursor;
                        among_var = find_among_b(a_3);
                        if (among_var == 0)
                        {
                            {
                                cursor = limit - c2;
                                goto lab1;
                            }
                        }
                        bra = cursor;
                        if (!r_R2())
                            {
                                cursor = limit - c2;
                                goto lab1;
                            }
                        slice_del();
                        switch (among_var) {
                            case 1:
                                ket = cursor;
                                if (!(eq_s_b("at")))
                                {
                                    {
                                        cursor = limit - c2;
                                        goto lab1;
                                    }
                                }
                                bra = cursor;
                                if (!r_R2())
                                    {
                                        cursor = limit - c2;
                                        goto lab1;
                                    }
                                slice_del();
                                break;
                        }
                    lab1: ; 
                    }
                    break;
                case 7:
                    if (!r_R2())
                        return false;
                    slice_del();
                    {
                        int c3 = limit - cursor;
                        ket = cursor;
                        if (find_among_b(a_4) == 0)
                        {
                            {
                                cursor = limit - c3;
                                goto lab2;
                            }
                        }
                        bra = cursor;
                        if (!r_R2())
                            {
                                cursor = limit - c3;
                                goto lab2;
                            }
                        slice_del();
                    lab2: ; 
                    }
                    break;
                case 8:
                    if (!r_R2())
                        return false;
                    slice_del();
                    {
                        int c4 = limit - cursor;
                        ket = cursor;
                        if (find_among_b(a_5) == 0)
                        {
                            {
                                cursor = limit - c4;
                                goto lab3;
                            }
                        }
                        bra = cursor;
                        if (!r_R2())
                            {
                                cursor = limit - c4;
                                goto lab3;
                            }
                        slice_del();
                    lab3: ; 
                    }
                    break;
                case 9:
                    if (!r_R2())
                        return false;
                    slice_del();
                    {
                        int c5 = limit - cursor;
                        ket = cursor;
                        if (!(eq_s_b("at")))
                        {
                            {
                                cursor = limit - c5;
                                goto lab4;
                            }
                        }
                        bra = cursor;
                        if (!r_R2())
                            {
                                cursor = limit - c5;
                                goto lab4;
                            }
                        slice_del();
                    lab4: ; 
                    }
                    break;
            }
            return true;
        }

        private bool r_y_verb_suffix()
        {
            if (cursor < I_pV)
            {
                return false;
            }
            int c2 = limit_backward;
            limit_backward = I_pV;
            ket = cursor;
            if (find_among_b(a_7) == 0)
            {
                {
                    limit_backward = c2;
                    return false;
                }
            }
            bra = cursor;
            limit_backward = c2;
            if (!(eq_s_b("u")))
            {
                return false;
            }
            slice_del();
            return true;
        }

        private bool r_verb_suffix()
        {
            int among_var;
            if (cursor < I_pV)
            {
                return false;
            }
            int c2 = limit_backward;
            limit_backward = I_pV;
            ket = cursor;
            among_var = find_among_b(a_8);
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
                    {
                        int c3 = limit - cursor;
                        if (!(eq_s_b("u")))
                        {
                            {
                                cursor = limit - c3;
                                goto lab0;
                            }
                        }
                        {
                            int c4 = limit - cursor;
                            if (!(eq_s_b("g")))
                            {
                                {
                                    cursor = limit - c3;
                                    goto lab0;
                                }
                            }
                            cursor = limit - c4;
                        }
                    lab0: ; 
                    }
                    bra = cursor;
                    slice_del();
                    break;
                case 2:
                    slice_del();
                    break;
            }
            return true;
        }

        private bool r_residual_suffix()
        {
            int among_var;
            ket = cursor;
            among_var = find_among_b(a_9);
            if (among_var == 0)
            {
                return false;
            }
            bra = cursor;
            switch (among_var) {
                case 1:
                    if (!r_RV())
                        return false;
                    slice_del();
                    break;
                case 2:
                    if (!r_RV())
                        return false;
                    slice_del();
                    {
                        int c1 = limit - cursor;
                        ket = cursor;
                        if (!(eq_s_b("u")))
                        {
                            {
                                cursor = limit - c1;
                                goto lab0;
                            }
                        }
                        bra = cursor;
                        {
                            int c2 = limit - cursor;
                            if (!(eq_s_b("g")))
                            {
                                {
                                    cursor = limit - c1;
                                    goto lab0;
                                }
                            }
                            cursor = limit - c2;
                        }
                        if (!r_RV())
                            {
                                cursor = limit - c1;
                                goto lab0;
                            }
                        slice_del();
                    lab0: ; 
                    }
                    break;
            }
            return true;
        }

        protected override bool stem()
        {
            r_mark_regions();
            limit_backward = cursor;
            cursor = limit;
            {
                int c2 = limit - cursor;
                r_attached_pronoun();
                cursor = limit - c2;
            }
            {
                int c3 = limit - cursor;
                {
                    int c4 = limit - cursor;
                    if (!r_standard_suffix())
                        goto lab2;
                    goto lab1;
                lab2: ; 
                    cursor = limit - c4;
                    if (!r_y_verb_suffix())
                        goto lab3;
                    goto lab1;
                lab3: ; 
                    cursor = limit - c4;
                    if (!r_verb_suffix())
                        goto lab0;
                }
            lab1: ; 
            lab0: ; 
                cursor = limit - c3;
            }
            {
                int c5 = limit - cursor;
                r_residual_suffix();
                cursor = limit - c5;
            }
            cursor = limit_backward;
            {
                int c6 = cursor;
                r_postlude();
                cursor = c6;
            }
            return true;
        }

    }
}

