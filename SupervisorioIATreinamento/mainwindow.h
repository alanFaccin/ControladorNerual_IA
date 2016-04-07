#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QWidget>
#include <QLineEdit>
#include <QLabel>
#include <QVBoxLayout>
#include <QGridLayout>
#include <QPushButton>

#include "graphs/qcustomplot.h"

class MainWindow : public QMainWindow
{
    Q_OBJECT

    QWidget * _widget;

    QLabel * _labelNumeroEpocas;
    QLabel * _labelPrecisao;
    QLabel * _labelTaxaAprendizado;
    QLabel * _labelAmostraTreinamento;
    QLabel * _labelSaidaDesejada;
    QLabel * _labelGuardarPesos;

    QLineEdit * _lineEditNumeroEpocas;
    QLineEdit * _lineEditPrecisao;
    QLineEdit * _lineEditTaxaAprendizado;
    QLineEdit * _lineEditAmostraTreinamento;
    QLineEdit * _lineEditSaidaDesejada;
    QLineEdit * _lineEditGuardarPesos;

    QPushButton * _buttonSelecionarArquivoAmostas;
    QPushButton * _buttonSelecionarArquivoSaidas;
    QPushButton * _buttonSelecionarDiretorioGuardarPesos;
    QPushButton * _buttonIniciarTreinamento;
    QPushButton * _buttonGuardarPesos;

    QGridLayout * _layoutForm;

    QCustomPlot * _chart;

public:
    MainWindow();
    ~MainWindow();
    double FuncaoAtivacao(double net, int funcao, double a);
    double derivada(double net, int funcao, double a);
    void zeraPesos(int camada);
    void zeraVetoresNeuronios(int camada);
    void randomizaPesos(int camada);


public slots:    
    void slotSelecionarArquivoAmostraTreinamento();
    void slotSelecionarArquivoSaidaDeseja();
    void slotSelecionarDiretorioGuardarPesos();
    void slotIniciarTreinamento();
    void slotGuardarPesos();
};

#endif // MAINWINDOW_H
