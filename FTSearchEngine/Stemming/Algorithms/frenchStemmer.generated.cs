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
    public partial class FrenchStemmer : Stemmer
    {
        private int I_p2;
        private int I_p1;
        private int I_pV;

        private const string g_v = "aeiouy\u00E2\u00E0\u00EB\u00E9\u00EA\u00E8\u00EF\u00EE\u00F4\u00FB\u00F9";
        private const string g_keep_with_s = "aiou\u00E8s";
        private static readonly Among[] a_0 = new[] 
        {
            new Among("col", -1, -1),
            new Among("par", -1, -1),
            new Among("tap", -1, -1)
        };

        private static readonly Among[] a_1 = new[] 
        {
            new Among("", -1, 7),
            new Among("H", 0, 6),
            new Among("He", 1, 4),
            new Among("Hi", 1, 5),
            new Among("I", 0, 1),
            new Among("U", 0, 2),
            new Among("Y", 0, 3)
        };

        private static readonly Among[] a_2 = new[] 
        {
            new Among("iqU", -1, 3),
            new Among("abl", -1, 3),
            new Among("I\u00E8r", -1, 4),
            new Among("i\u00E8r", -1, 4),
            new Among("eus", -1, 2),
            new Among("iv", -1, 1)
        };

        private static readonly Among[] a_3 = new[] 
        {
            new Among("ic", -1, 2),
            new Among("abil", -1, 1),
            new Among("iv", -1, 3)
        };

        private static readonly Among[] a_4 = new[] 
        {
            new Among("iqUe", -1, 1),
            new Among("atrice", -1, 2),
            new Among("ance", -1, 1),
            new Among("ence", -1, 5),
            new Among("logie", -1, 3),
            new Among("able", -1, 1),
            new Among("isme", -1, 1),
            new Among("euse", -1, 11),
            new Among("iste", -1, 1),
            new Among("ive", -1, 8),
            new Among("if", -1, 8),
            new Among("usion", -1, 4),
            new Among("ation", -1, 2),
            new Among("ution", -1, 4),
            new Among("ateur", -1, 2),
            new Among("iqUes", -1, 1),
            new Among("atrices", -1, 2),
            new Among("ances", -1, 1),
            new Among("ences", -1, 5),
            new Among("logies", -1, 3),
            new Among("ables", -1, 1),
            new Among("ismes", -1, 1),
            new Among("euses", -1, 11),
            new Among("istes", -1, 1),
            new Among("ives", -1, 8),
            new Among("ifs", -1, 8),
            new Among("usions", -1, 4),
            new Among("ations", -1, 2),
            new Among("utions", -1, 4),
            new Among("ateurs", -1, 2),
            new Among("ments", -1, 15),
            new Among("ements", 30, 6),
            new Among("issements", 31, 12),
            new Among("it\u00E9s", -1, 7),
            new Among("ment", -1, 15),
            new Among("ement", 34, 6),
            new Among("issement", 35, 12),
            new Among("amment", 34, 13),
            new Among("emment", 34, 14),
            new Among("aux", -1, 10),
            new Among("eaux", 39, 9),
            new Among("eux", -1, 1),
            new Among("it\u00E9", -1, 7)
        };

        private static readonly Among[] a_5 = new[] 
        {
            new Among("ira", -1, 1),
            new Among("ie", -1, 1),
            new Among("isse", -1, 1),
            new Among("issante", -1, 1),
            new Among("i", -1, 1),
            new Among("irai", 4, 1),
            new Among("ir", -1, 1),
            new Among("iras", -1, 1),
            new Among("ies", -1, 1),
            new Among("\u00EEmes", -1, 1),
            new Among("isses", -1, 1),
            new Among("issantes", -1, 1),
            new Among("\u00EEtes", -1, 1),
            new Among("is", -1, 1),
            new Among("irais", 13, 1),
            new Among("issais", 13, 1),
            new Among("irions", -1, 1),
            new Among("issions", -1, 1),
            new Among("irons", -1, 1),
            new Among("issons", -1, 1),
            new Among("issants", -1, 1),
            new Among("it", -1, 1),
            new Among("irait", 21, 1),
            new Among("issait", 21, 1),
            new Among("issant", -1, 1),
            new Among("iraIent", -1, 1),
            new Among("issaIent", -1, 1),
            new Among("irent", -1, 1),
            new Among("issent", -1, 1),
            new Among("iront", -1, 1),
            new Among("\u00EEt", -1, 1),
            new Among("iriez", -1, 1),
            new Among("issiez", -1, 1),
            new Among("irez", -1, 1),
            new Among("issez", -1, 1)
        };

        private static readonly Among[] a_6 = new[] 
        {
            new Among("a", -1, 3),
            new Among("era", 0, 2),
            new Among("asse", -1, 3),
            new Among("ante", -1, 3),
            new Among("\u00E9e", -1, 2),
            new Among("ai", -1, 3),
            new Among("erai", 5, 2),
            new Among("er", -1, 2),
            new Among("as", -1, 3),
            new Among("eras", 8, 2),
            new Among("\u00E2mes", -1, 3),
            new Among("asses", -1, 3),
            new Among("antes", -1, 3),
            new Among("\u00E2tes", -1, 3),
            new Among("\u00E9es", -1, 2),
            new Among("ais", -1, 3),
            new Among("erais", 15, 2),
            new Among("ions", -1, 1),
            new Among("erions", 17, 2),
            new Among("assions", 17, 3),
            new Among("erons", -1, 2),
            new Among("ants", -1, 3),
            new Among("\u00E9s", -1, 2),
            new Among("ait", -1, 3),
            new Among("erait", 23, 2),
            new Among("ant", -1, 3),
            new Among("aIent", -1, 3),
            new Among("eraIent", 26, 2),
            new Among("\u00E8rent", -1, 2),
            new Among("assent", -1, 3),
            new Among("eront", -1, 2),
            new Among("\u00E2t", -1, 3),
            new Among("ez", -1, 2),
            new Among("iez", 32, 2),
            new Among("eriez", 33, 2),
            new Among("assiez", 33, 3),
            new Among("erez", 32, 2),
            new Among("\u00E9", -1, 2)
        };

        private static readonly Among[] a_7 = new[] 
        {
            new Among("e", -1, 3),
            new Among("I\u00E8re", 0, 2),
            new Among("i\u00E8re", 0, 2),
            new Among("ion", -1, 1),
            new Among("Ier", -1, 2),
            new Among("ier", -1, 2)
        };

        private static readonly Among[] a_8 = new[] 
        {
            new Among("ell", -1, -1),
            new Among("eill", -1, -1),
            new Among("enn", -1, -1),
            new Among("onn", -1, -1),
            new Among("ett", -1, -1)
        };



        private bool r_prelude()
        {
            while (true)
            {
                int c1 = cursor;
                while (true)
                {
                    int c2 = cursor;
                    {
                        int c3 = cursor;
                        if (in_grouping(g_v, 97, 251, false) != 0)
                        {
                            goto lab3;
                        }
                        bra = cursor;
                        {
                            int c4 = cursor;
                            if (!(eq_s("u")))
                            {
                                goto lab5;
                            }
                            ket = cursor;
                            if (in_grouping(g_v, 97, 251, false) != 0)
                            {
                                goto lab5;
                            }
                            slice_from("U");
                            goto lab4;
                        lab5: ; 
                            cursor = c4;
                            if (!(eq_s("i")))
                            {
                                goto lab6;
                            }
                            ket = cursor;
                            if (in_grouping(g_v, 97, 251, false) != 0)
                            {
                                goto lab6;
                            }
                            slice_from("I");
                            goto lab4;
                        lab6: ; 
                            cursor = c4;
                            if (!(eq_s("y")))
                            {
                                goto lab3;
                            }
                            ket = cursor;
                            slice_from("Y");
                        }
                    lab4: ; 
                        goto lab2;
                    lab3: ; 
                        cursor = c3;
                        bra = cursor;
                        if (!(eq_s("\u00EB")))
                        {
                            goto lab7;
                        }
                        ket = cursor;
                        slice_from("He");
                        goto lab2;
                    lab7: ; 
                        cursor = c3;
                        bra = cursor;
                        if (!(eq_s("\u00EF")))
                        {
                            goto lab8;
                        }
                        ket = cursor;
                        slice_from("Hi");
                        goto lab2;
                    lab8: ; 
                        cursor = c3;
                        bra = cursor;
                        if (!(eq_s("y")))
                        {
                            goto lab9;
                        }
                        ket = cursor;
                        if (in_grouping(g_v, 97, 251, false) != 0)
                        {
                            goto lab9;
                        }
                        slice_from("Y");
                        goto lab2;
                    lab9: ; 
                        cursor = c3;
                        if (!(eq_s("q")))
                        {
                            goto lab1;
                        }
                        bra = cursor;
                        if (!(eq_s("u")))
                        {
                            goto lab1;
                        }
                        ket = cursor;
                        slice_from("U");
                    }
                lab2: ; 
                    cursor = c2;
                    break;
                lab1: ; 
                    cursor = c2;
                    if (cursor >= limit)
                    {
                        goto lab0;
                    }
                    cursor++;
                }
                continue;
            lab0: ; 
                cursor = c1;
                break;
            }
            return true;
        }

        private bool r_mark_regions()
        {
            I_pV = limit;
            I_p1 = limit;
            I_p2 = limit;
            {
                int c1 = cursor;
                {
                    int c2 = cursor;
                    if (in_grouping(g_v, 97, 251, false) != 0)
                    {
                        goto lab2;
                    }
                    if (in_grouping(g_v, 97, 251, false) != 0)
                    {
                        goto lab2;
                    }
                    if (cursor >= limit)
                    {
                        goto lab2;
                    }
                    cursor++;
                    goto lab1;
                lab2: ; 
                    cursor = c2;
                    if (find_among(a_0) == 0)
                    {
                        goto lab3;
                    }
                    goto lab1;
                lab3: ; 
                    cursor = c2;
                    if (cursor >= limit)
                    {
                        goto lab0;
                    }
                    cursor++;
                    {

                        int ret = out_grouping(g_v, 97, 251, true);
                        if (ret < 0)
                        {
                            goto lab0;
                        }

                        cursor += ret;
                    }
                }
            lab1: ; 
                I_pV = cursor;
            lab0: ; 
                cursor = c1;
            }
            {
                int c4 = cursor;
                {

                    int ret = out_grouping(g_v, 97, 251, true);
                    if (ret < 0)
                    {
                        goto lab4;
                    }

                    cursor += ret;
                }
                {

                    int ret = in_grouping(g_v, 97, 251, true);
                    if (ret < 0)
                    {
                        goto lab4;
                    }

                    cursor += ret;
                }
                I_p1 = cursor;
                {

                    int ret = out_grouping(g_v, 97, 251, true);
                    if (ret < 0)
                    {
                        goto lab4;
                    }

                    cursor += ret;
                }
                {

                    int ret = in_grouping(g_v, 97, 251, true);
                    if (ret < 0)
                    {
                        goto lab4;
                    }

                    cursor += ret;
                }
                I_p2 = cursor;
            lab4: ; 
                cursor = c4;
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
                among_var = find_among(a_1);
                if (among_var == 0)
                {
                    goto lab0;
                }
                ket = cursor;
                switch (among_var) {
                    case 1:
                        slice_from("i");
                        break;
                    case 2:
                        slice_from("u");
                        break;
                    case 3:
                        slice_from("y");
                        break;
                    case 4:
                        slice_from("\u00EB");
                        break;
                    case 5:
                        slice_from("\u00EF");
                        break;
                    case 6:
                        slice_del();
                        break;
                    case 7:
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

        private bool r_standard_suffix()
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
                        {
                            int c2 = limit - cursor;
                            if (!r_R2())
                                goto lab2;
                            slice_del();
                            goto lab1;
                        lab2: ; 
                            cursor = limit - c2;
                            slice_from("iqU");
                        }
                    lab1: ; 
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
                    slice_from("ent");
                    break;
                case 6:
                    if (!r_RV())
                        return false;
                    slice_del();
                    {
                        int c3 = limit - cursor;
                        ket = cursor;
                        among_var = find_among_b(a_2);
                        if (among_var == 0)
                        {
                            {
                                cursor = limit - c3;
                                goto lab3;
                            }
                        }
                        bra = cursor;
                        switch (among_var) {
                            case 1:
                                if (!r_R2())
                                    {
                                        cursor = limit - c3;
                                        goto lab3;
                                    }
                                slice_del();
                                ket = cursor;
                                if (!(eq_s_b("at")))
                                {
                                    {
                                        cursor = limit - c3;
                                        goto lab3;
                                    }
                                }
                                bra = cursor;
                                if (!r_R2())
                                    {
                                        cursor = limit - c3;
                                        goto lab3;
                                    }
                                slice_del();
                                break;
                            case 2:
                                {
                                    int c4 = limit - cursor;
                                    if (!r_R2())
                                        goto lab5;
                                    slice_del();
                                    goto lab4;
                                lab5: ; 
                                    cursor = limit - c4;
                                    if (!r_R1())
                                        {
                                            cursor = limit - c3;
                                            goto lab3;
                                        }
                                    slice_from("eux");
                                }
                            lab4: ; 
                                break;
                            case 3:
                                if (!r_R2())
                                    {
                                        cursor = limit - c3;
                                        goto lab3;
                                    }
                                slice_del();
                                break;
                            case 4:
                                if (!r_RV())
                                    {
                                        cursor = limit - c3;
                                        goto lab3;
                                    }
                                slice_from("i");
                                break;
                        }
                    lab3: ; 
                    }
                    break;
                case 7:
                    if (!r_R2())
                        return false;
                    slice_del();
                    {
                        int c5 = limit - cursor;
                        ket = cursor;
                        among_var = find_among_b(a_3);
                        if (among_var == 0)
                        {
                            {
                                cursor = limit - c5;
                                goto lab6;
                            }
                        }
                        bra = cursor;
                        switch (among_var) {
                            case 1:
                                {
                                    int c6 = limit - cursor;
                                    if (!r_R2())
                                        goto lab8;
                                    slice_del();
                                    goto lab7;
                                lab8: ; 
                                    cursor = limit - c6;
                                    slice_from("abl");
                                }
                            lab7: ; 
                                break;
                            case 2:
                                {
                                    int c7 = limit - cursor;
                                    if (!r_R2())
                                        goto lab10;
                                    slice_del();
                                    goto lab9;
                                lab10: ; 
                                    cursor = limit - c7;
                                    slice_from("iqU");
                                }
                            lab9: ; 
                                break;
                            case 3:
                                if (!r_R2())
                                    {
                                        cursor = limit - c5;
                                        goto lab6;
                                    }
                                slice_del();
                                break;
                        }
                    lab6: ; 
                    }
                    break;
                case 8:
                    if (!r_R2())
                        return false;
                    slice_del();
                    {
                        int c8 = limit - cursor;
                        ket = cursor;
                        if (!(eq_s_b("at")))
                        {
                            {
                                cursor = limit - c8;
                                goto lab11;
                            }
                        }
                        bra = cursor;
                        if (!r_R2())
                            {
                                cursor = limit - c8;
                                goto lab11;
                            }
                        slice_del();
                        ket = cursor;
                        if (!(eq_s_b("ic")))
                        {
                            {
                                cursor = limit - c8;
                                goto lab11;
                            }
                        }
                        bra = cursor;
                        {
                            int c9 = limit - cursor;
                            if (!r_R2())
                                goto lab13;
                            slice_del();
                            goto lab12;
                        lab13: ; 
                            cursor = limit - c9;
                            slice_from("iqU");
                        }
                    lab12: ; 
                    lab11: ; 
                    }
                    break;
                case 9:
                    slice_from("eau");
                    break;
                case 10:
                    if (!r_R1())
                        return false;
                    slice_from("al");
                    break;
                case 11:
                    {
                        int c10 = limit - cursor;
                        if (!r_R2())
                            goto lab15;
                        slice_del();
                        goto lab14;
                    lab15: ; 
                        cursor = limit - c10;
                        if (!r_R1())
                            return false;
                        slice_from("eux");
                    }
                lab14: ; 
                    break;
                case 12:
                    if (!r_R1())
                        return false;
                    if (out_grouping_b(g_v, 97, 251, false) != 0)
                    {
                        return false;
                    }
                    slice_del();
                    break;
                case 13:
                    if (!r_RV())
                        return false;
                    slice_from("ant");
                    return false;
                    break;
                case 14:
                    if (!r_RV())
                        return false;
                    slice_from("ent");
                    return false;
                    break;
                case 15:
                    {
                        int c11 = limit - cursor;
                        if (in_grouping_b(g_v, 97, 251, false) != 0)
                        {
                            return false;
                        }
                        if (!r_RV())
                            return false;
                        cursor = limit - c11;
                    }
                    slice_del();
                    return false;
                    break;
            }
            return true;
        }

        private bool r_i_verb_suffix()
        {
            if (cursor < I_pV)
            {
                return false;
            }
            int c2 = limit_backward;
            limit_backward = I_pV;
            ket = cursor;
            if (find_among_b(a_5) == 0)
            {
                {
                    limit_backward = c2;
                    return false;
                }
            }
            bra = cursor;
            {
                int c3 = limit - cursor;
                if (!(eq_s_b("H")))
                {
                    goto lab0;
                }
                {
                    limit_backward = c2;
                    return false;
                }
            lab0: ; 
                cursor = limit - c3;
            }
            if (out_grouping_b(g_v, 97, 251, false) != 0)
            {
                {
                    limit_backward = c2;
                    return false;
                }
            }
            slice_del();
            limit_backward = c2;
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
            among_var = find_among_b(a_6);
            if (among_var == 0)
            {
                {
                    limit_backward = c2;
                    return false;
                }
            }
            bra = cursor;
            switch (among_var) {
                case 1:
                    if (!r_R2())
                        {
                            limit_backward = c2;
                            return false;
                        }
                    slice_del();
                    break;
                case 2:
                    slice_del();
                    break;
                case 3:
                    slice_del();
                    {
                        int c3 = limit - cursor;
                        ket = cursor;
                        if (!(eq_s_b("e")))
                        {
                            {
                                cursor = limit - c3;
                                goto lab0;
                            }
                        }
                        bra = cursor;
                        slice_del();
                    lab0: ; 
                    }
                    break;
            }
            limit_backward = c2;
            return true;
        }

        private bool r_residual_suffix()
        {
            int among_var;
            {
                int c1 = limit - cursor;
                ket = cursor;
                if (!(eq_s_b("s")))
                {
                    {
                        cursor = limit - c1;
                        goto lab0;
                    }
                }
                bra = cursor;
                {
                    int c2 = limit - cursor;
                    {
                        int c3 = limit - cursor;
                        if (!(eq_s_b("Hi")))
                        {
                            goto lab2;
                        }
                        goto lab1;
                    lab2: ; 
                        cursor = limit - c3;
                        if (out_grouping_b(g_keep_with_s, 97, 232, false) != 0)
                        {
                            {
                                cursor = limit - c1;
                                goto lab0;
                            }
                        }
                    }
                lab1: ; 
                    cursor = limit - c2;
                }
                slice_del();
            lab0: ; 
            }
            if (cursor < I_pV)
            {
                return false;
            }
            int c5 = limit_backward;
            limit_backward = I_pV;
            ket = cursor;
            among_var = find_among_b(a_7);
            if (among_var == 0)
            {
                {
                    limit_backward = c5;
                    return false;
                }
            }
            bra = cursor;
            switch (among_var) {
                case 1:
                    if (!r_R2())
                        {
                            limit_backward = c5;
                            return false;
                        }
                    {
                        int c6 = limit - cursor;
                        if (!(eq_s_b("s")))
                        {
                            goto lab4;
                        }
                        goto lab3;
                    lab4: ; 
                        cursor = limit - c6;
                        if (!(eq_s_b("t")))
                        {
                            {
                                limit_backward = c5;
                                return false;
                            }
                        }
                    }
                lab3: ; 
                    slice_del();
                    break;
                case 2:
                    slice_from("i");
                    break;
                case 3:
                    slice_del();
                    break;
            }
            limit_backward = c5;
            return true;
        }

        private bool r_un_double()
        {
            {
                int c1 = limit - cursor;
                if (find_among_b(a_8) == 0)
                {
                    return false;
                }
                cursor = limit - c1;
            }
            ket = cursor;
            if (cursor <= limit_backward)
            {
                return false;
            }
            cursor--;
            bra = cursor;
            slice_del();
            return true;
        }

        private bool r_un_accent()
        {
            {
                int c1 = 1;
                while (true)
                {
                    if (out_grouping_b(g_v, 97, 251, false) != 0)
                    {
                        goto lab0;
                    }
                    c1--;
                    continue;
                lab0: ; 
                    break;
                }
                if (c1 > 0)
                {
                    return false;
                }
            }
            ket = cursor;
            {
                int c3 = limit - cursor;
                if (!(eq_s_b("\u00E9")))
                {
                    goto lab2;
                }
                goto lab1;
            lab2: ; 
                cursor = limit - c3;
                if (!(eq_s_b("\u00E8")))
                {
                    return false;
                }
            }
        lab1: ; 
            bra = cursor;
            slice_from("e");
            return true;
        }

        protected override bool stem()
        {
            {
                int c1 = cursor;
                r_prelude();
                cursor = c1;
            }
            r_mark_regions();
            limit_backward = cursor;
            cursor = limit;
            {
                int c3 = limit - cursor;
                {
                    int c4 = limit - cursor;
                    int c5 = limit - cursor;
                    {
                        int c6 = limit - cursor;
                        if (!r_standard_suffix())
                            goto lab4;
                        goto lab3;
                    lab4: ; 
                        cursor = limit - c6;
                        if (!r_i_verb_suffix())
                            goto lab5;
                        goto lab3;
                    lab5: ; 
                        cursor = limit - c6;
                        if (!r_verb_suffix())
                            goto lab2;
                    }
                lab3: ; 
                    cursor = limit - c5;
                    {
                        int c7 = limit - cursor;
                        ket = cursor;
                        {
                            int c8 = limit - cursor;
                            if (!(eq_s_b("Y")))
                            {
                                goto lab8;
                            }
                            bra = cursor;
                            slice_from("i");
                            goto lab7;
                        lab8: ; 
                            cursor = limit - c8;
                            if (!(eq_s_b("\u00E7")))
                            {
                                {
                                    cursor = limit - c7;
                                    goto lab6;
                                }
                            }
                            bra = cursor;
                            slice_from("c");
                        }
                    lab7: ; 
                    lab6: ; 
                    }
                    goto lab1;
                lab2: ; 
                    cursor = limit - c4;
                    if (!r_residual_suffix())
                        goto lab0;
                }
            lab1: ; 
            lab0: ; 
                cursor = limit - c3;
            }
            {
                int c9 = limit - cursor;
                r_un_double();
                cursor = limit - c9;
            }
            {
                int c10 = limit - cursor;
                r_un_accent();
                cursor = limit - c10;
            }
            cursor = limit_backward;
            {
                int c11 = cursor;
                r_postlude();
                cursor = c11;
            }
            return true;
        }

    }
}

