package com.company;

import com.sun.org.apache.xpath.internal.SourceTree;

import java.util.ArrayList;
import java.util.Random;

public class Main {

    public static void main(String[] args) {
        Random myRandom = new Random();
        Random anotherRandomGenerator = new Random();

        //methods

        int number = myRandom.nextInt();
        System.out.println(number);

        double randy = anotherRandomGenerator.nextDouble();
        System.out.println(randy);

        int numberToo = myRandom.nextInt();
        System.out.println(numberToo);

        double randyT = anotherRandomGenerator.nextDouble();
        System.out.println(randyT);

        //array

        ArrayList<Integer> myList = new ArrayList<>();

        boolean addy = myList.add(12);
        System.out.println(addy);

        boolean addy2 = myList.add(14);
        System.out.println(addy2);

        int sizzy = myList.size();
        System.out.println(sizzy);

        int getty = myList.get(0);
        System.out.println(getty);

        int getty2 = myList.get(1);
        System.out.println(getty2);

        int setty = myList.set(0,5);

        int getty3 = myList.get(0);
        System.out.println(getty3);

        int gett4 = 

    }
}