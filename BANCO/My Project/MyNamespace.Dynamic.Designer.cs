using System;
using System.ComponentModel;
using System.Diagnostics;

namespace BANCO.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CalendarioPago m_CalendarioPago;

            public CalendarioPago CalendarioPago
            {
                [DebuggerHidden]
                get
                {
                    m_CalendarioPago = Create__Instance__(m_CalendarioPago);
                    return m_CalendarioPago;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CalendarioPago))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CalendarioPago);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Cliente m_Cliente;

            public Cliente Cliente
            {
                [DebuggerHidden]
                get
                {
                    m_Cliente = Create__Instance__(m_Cliente);
                    return m_Cliente;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Cliente))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Cliente);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Credito m_Credito;

            public Credito Credito
            {
                [DebuggerHidden]
                get
                {
                    m_Credito = Create__Instance__(m_Credito);
                    return m_Credito;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Credito))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Credito);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Cuenta m_Cuenta;

            public Cuenta Cuenta
            {
                [DebuggerHidden]
                get
                {
                    m_Cuenta = Create__Instance__(m_Cuenta);
                    return m_Cuenta;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Cuenta))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Cuenta);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form1 m_Form1;

            public Form1 Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Movimiento m_Movimiento;

            public Movimiento Movimiento
            {
                [DebuggerHidden]
                get
                {
                    m_Movimiento = Create__Instance__(m_Movimiento);
                    return m_Movimiento;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Movimiento))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Movimiento);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Pago m_Pago;

            public Pago Pago
            {
                [DebuggerHidden]
                get
                {
                    m_Pago = Create__Instance__(m_Pago);
                    return m_Pago;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Pago))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Pago);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Sucursal m_Sucursal;

            public Sucursal Sucursal
            {
                [DebuggerHidden]
                get
                {
                    m_Sucursal = Create__Instance__(m_Sucursal);
                    return m_Sucursal;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Sucursal))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Sucursal);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Tablas m_Tablas;

            public Tablas Tablas
            {
                [DebuggerHidden]
                get
                {
                    m_Tablas = Create__Instance__(m_Tablas);
                    return m_Tablas;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Tablas))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Tablas);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TipoCredito m_TipoCredito;

            public TipoCredito TipoCredito
            {
                [DebuggerHidden]
                get
                {
                    m_TipoCredito = Create__Instance__(m_TipoCredito);
                    return m_TipoCredito;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TipoCredito))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TipoCredito);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TipoCuenta m_TipoCuenta;

            public TipoCuenta TipoCuenta
            {
                [DebuggerHidden]
                get
                {
                    m_TipoCuenta = Create__Instance__(m_TipoCuenta);
                    return m_TipoCuenta;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TipoCuenta))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TipoCuenta);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TipoMovimiento m_TipoMovimiento;

            public TipoMovimiento TipoMovimiento
            {
                [DebuggerHidden]
                get
                {
                    m_TipoMovimiento = Create__Instance__(m_TipoMovimiento);
                    return m_TipoMovimiento;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TipoMovimiento))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TipoMovimiento);
                }
            }

        }


    }
}