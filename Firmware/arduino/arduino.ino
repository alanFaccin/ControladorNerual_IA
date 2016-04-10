#define NUM_ENTRADAS 1
#define NUM_NEURONIOS_CAMADA_UM 15
#define NUM_NEURONIOS_CAMADA_DOIS 5


//Configuracoes da Rede Perceptron Multicamadas.
int i = 0, j = 0, k = 0, n = 0, funcao = 0;
float soma = 0;

//PESOS
double w1[NUM_NEURONIOS_CAMADA_UM * NUM_ENTRADAS] = {2.77527, -2.68807, 2.78896, -2.68594, 2.79734, 2.78069, -2.69344, -2.68773, 2.79767, 2.78704, -2.69466, -2.62832, -2.68305, -2.69626, -2.6919};
double w2[NUM_NEURONIOS_CAMADA_DOIS * NUM_NEURONIOS_CAMADA_UM] = {2.83499, -6.81413, 3.77187, -6.65016, 4.53635, 3.22756, -7.51466, -6.79649, 4.45951, 3.8651, -7.784, -1.40238, -6.14016, -8.02303, -7.3168, 3.42395, -11.0716, 4.22312, -10.9022, 4.8119, 3.70267, -11.7213, -10.9599, 4.74514, 4.32978, -11.9661, -4.07354, -10.4813, -12.0853, -11.4578, -1.03705, -0.728428, -1.04469, -0.752167, -1.06746, -0.980785, -0.703704, -0.664354, -1.05376, -1.02538, -0.671998, -0.881026, -0.744667, -0.642387, -0.683677, -3.32672, 11.233, -3.99426, 11.0983, -4.57585, -3.62537, 11.8471, 11.2192, -4.53627, -4.10691, 12.083, 4.20379, 10.7038, 12.3174, 11.6856, -1.95251, 9.51693, -2.34574, 9.45841, -2.63522, -2.12816, 9.94951, 9.48963, -2.58224, -2.43489, 10.1596, 3.2942, 9.07601, 10.2821, 9.80975};

//Delta PESOS
double dw1[NUM_NEURONIOS_CAMADA_UM * NUM_ENTRADAS];
double dw2[NUM_NEURONIOS_CAMADA_DOIS * NUM_NEURONIOS_CAMADA_UM];

//Entradas
double Entrada_I1[NUM_NEURONIOS_CAMADA_UM] = {0};
double Entrada_I2[NUM_NEURONIOS_CAMADA_DOIS]  = {0};

//SAIDAS
double saida_y1[NUM_NEURONIOS_CAMADA_UM] = {0};
double saida_y2[NUM_NEURONIOS_CAMADA_DOIS]  = {0};

double saidas[NUM_NEURONIOS_CAMADA_DOIS] = {0};

int potenciometro     = 0;    // Define o pino do Arduino que o potenciômetro está conectado
double sensor         = 0;    //Variável que irá receber o sensor do potenciômetro
int ReleBomba1        = 13;   // contorla o acionamento da bomba1 de agua
int ReleBomba2        = 12;   // contorla o acionamento da bomba2 de agua
int ReleValvula1      = 11;   // contorla o acionamento da valvula1 de agua
int ReleValvula2      = 10;   // contorla o acionamento da valvula2 de agua
double VlrMaxPt       = 205; // valor maximo lido pelo potenciometro
double LeituraSensor  = 0.00;
String Recive         = "";



void setup() {

  pinMode(ReleBomba1, OUTPUT);
  pinMode(ReleBomba2, OUTPUT);
  pinMode(ReleValvula1, OUTPUT);
  pinMode(ReleValvula2, OUTPUT);
  Serial.begin(9600);

}



float funcao_ativacao(float net, int funcao, float a)
{
  if (!funcao)
  {

    /*
                    1
      y(n) = ---------------
             1 + exp(-a.net)
    */

    return ( 1.0 / (1.0 + exp(-a * net)) );

  }
  else
  {

    /*
             exp(a.net) - exp(-a.net)
      y(n) = ------------------------
             exp(a.net) + exp(-a.net)
    */

    return ( (exp(a * net) - exp(-a * net)) / (exp(a * net) + exp(-a * net)) );
  }
}

void ReadSensor() {

  LeituraSensor = analogRead(potenciometro); //Recebe o sensor do potenciômetro
  Serial.print("\n Valor lido:");
  Serial.println(LeituraSensor); //Mostra no Serial Monitor o sensor obtido do potenciômetro
  sensor = LeituraSensor / VlrMaxPt;
  Serial.print("%Valor Formatado:");
  Serial.println(sensor);
}

void verificaComandos() {
  // Se receber algo pela serial
  if (Serial.available() > 0 ) {
    // Lê toda string recebida
    Recive = Serial.readString();
    double a = (double) sensor;
    if (Recive == "*F") {
      while (a < 1.0) {

        digitalWrite(ReleBomba1, LOW);
        digitalWrite(ReleBomba2, LOW);

        digitalWrite(ReleValvula1, HIGH);
        digitalWrite(ReleValvula2, HIGH);
        Serial.print("#Saida da rede: ");
        Serial.print("0");
        Serial.print(" | ");
        Serial.print("0");
        Serial.print(" | ");
        Serial.print("0");
        Serial.print(" | ");
        Serial.print("1");
        Serial.print(" | ");
        Serial.println("1");
        ReadSensor();
        a = (double) sensor;
        delay(1000);
      }
    }
    if (Recive == "*E") {
      while (a > 0.2) {
        digitalWrite(ReleBomba1, HIGH);
        digitalWrite(ReleBomba2, HIGH);

        digitalWrite(ReleValvula1, LOW);
        digitalWrite(ReleValvula2, LOW);
        Serial.print("#Saida da rede: ");
        Serial.print("1");
        Serial.print(" | ");
        Serial.print("1");
        Serial.print(" | ");
        Serial.print("0");
        Serial.print(" | ");
        Serial.print("0");
        Serial.print(" | ");
        Serial.println("0");
        ReadSensor();
        a = (double) sensor;
        delay(1000);
      }
    }
  }
}

void loop() {

  ReadSensor();

  verificaComandos();


  //Cálculo para camada NUM_NEURONIOS_CAMADA_UM.
  n = 0;
  for (j = 0; j < NUM_NEURONIOS_CAMADA_UM; j++)
  {
    soma = 0;
    for (i = 0; i < NUM_ENTRADAS; i++)
    {
      soma += w1[n] * sensor;
      n += 1;
    }
    Entrada_I1[j] = soma;
    saida_y1[j] = funcao_ativacao(Entrada_I1[j], funcao, 1.0);
  }

  //Cálculo para camada NUM_NEURONIOS_CAMADA_DOIS.
  n = 0;
  for (j = 0; j < NUM_NEURONIOS_CAMADA_DOIS; j++)
  {
    soma = 0;
    for (i = 0; i < NUM_NEURONIOS_CAMADA_UM; i++)
    {
      soma += w2[n] * saida_y1[i];
      n += 1;
    }
    Entrada_I2[j] = soma;
    saida_y2[j] = funcao_ativacao(Entrada_I2[j], funcao, 1.0);
  }


  if (saida_y2[0] < 0.5) {
    saida_y2[0] = 0;
  } else {
    saida_y2[0] = 1;
  }

  if (saida_y2[1] < 0.5) {
    saida_y2[1] = 0;
  } else {
    saida_y2[1] = 1;
  }

  if (saida_y2[2] < 0.5) {
    saida_y2[2] = 0;
  } else {
    saida_y2[2] = 1;
  }

  if (saida_y2[3] < 0.5) {
    saida_y2[3] = 0;
  } else {
    saida_y2[3] = 1;
  }

  if (saida_y2[4] < 0.5) {
    saida_y2[4] = 0;
  } else {
    saida_y2[4] = 1;
  }

  int temp = 0;
  Serial.print("#Saida da rede: ");
  temp = (int) saida_y2[0];
  Serial.print(temp);
  Serial.print(" | ");
  temp = (int) saida_y2[1];
  Serial.print(temp);
  Serial.print(" | ");
  temp = (int) saida_y2[2];
  Serial.print(temp);
  Serial.print(" | ");
  temp = (int) saida_y2[3];
  Serial.print(temp);
  Serial.print(" | ");
  temp = (int) saida_y2[4];
  Serial.println(temp);

  digitalWrite(ReleValvula1, saida_y2[3]);
  digitalWrite(ReleBomba1, saida_y2[1]);
  digitalWrite(ReleValvula2, saida_y2[4]);
  digitalWrite(ReleBomba2, saida_y2[0]);



  delay(1000);



}



